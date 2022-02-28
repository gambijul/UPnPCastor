using Rssdp;
using System.Net;
using System.Text;
using UPnPCastor.Core.UPnP.Control;
using UPnPCastor.Core.UPnP.Service;

namespace UPnPCastor.Core.Soap
{
    public class SoapHttpRequest
    {
        private readonly SsdpDevice _device;
        private readonly UPnP.Service.AVTransport.Action _avTransportAction;

        public SoapHttpRequest(SsdpDevice device, UPnP.Service.AVTransport.Action avTransportAction)
        {
            _device = device;
            _avTransportAction = avTransportAction;
        }

        public async Task<object?> SendAsync()
        {
            SsdpService ssdpService = _device.Services.First(s => s.ServiceType == "AVTransport");
            Uri requestUri = new(_device.ToRootDevice().Location, ssdpService.ControlUrl);
            string uPnPServiceName = _avTransportAction.GetType().Name;

            using HttpClient client = new();

            client.DefaultRequestHeaders.Add("Pragma", "no-cache");
            client.DefaultRequestHeaders.Add("FriendlyName.DLNA.ORG", Environment.MachineName);
            client.DefaultRequestHeaders.Add("SOAPAction", $"{AVTransportService.Namespace}#{uPnPServiceName}");

            Envelope envelope = new() { Body = new(_avTransportAction) };
            StringContent httpContent = new(envelope.Serialize(), Encoding.UTF8, "text/xml");
            HttpResponseMessage response = await client.PostAsync(requestUri, httpContent);

            // UPnP error coming from the remote device
            if (response.StatusCode == HttpStatusCode.InternalServerError && Body.ParseFault(response)?.Detail.UPnPError is UPnPError uPnPError)
                throw new Exception($"UPnP error: {uPnPError.Code} {uPnPError.Description}.");

            // Generic exception
            if (!response.IsSuccessStatusCode) throw new Exception(response.ReasonPhrase);

            string content = await response.Content.ReadAsStringAsync();
            return Body.ParseResponse(response);
        }
    }
}