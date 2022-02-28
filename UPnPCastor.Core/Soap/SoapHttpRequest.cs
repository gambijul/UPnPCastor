using Rssdp;
using System.Net;
using System.Xml;
using System.Xml.Serialization;
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

        public async Task SendAsync()
        {
            SsdpService ssdpService = _device.Services.First(s => s.ServiceType == "AVTransport");
            Uri requestUri = new(_device.ToRootDevice().Location, ssdpService.ControlUrl);
            string uPnPServiceName = _avTransportAction.GetType().Name;

            using HttpClient client = new();

            //client.DefaultRequestHeaders.Add("Cache-Control", "no-cache");
            //client.DefaultRequestHeaders.Add("Connection", "Close");
            client.DefaultRequestHeaders.Add("Pragma", "no-cache");
            //client.DefaultRequestHeaders.Add("Content-Type", "text/xml; charset=\"utf-8\"");
            client.DefaultRequestHeaders.Add("FriendlyName.DLNA.ORG", Environment.MachineName);
            client.DefaultRequestHeaders.Add("SOAPAction", $"{AVTransportService.Namespace}#{uPnPServiceName}");

            Envelope envelope = new() { Body = new(_avTransportAction) };
            StringContent httpContent = new(envelope.Serialize(), null, "text/xml");
            HttpResponseMessage response = await client.PostAsync(requestUri, httpContent);

            // UPnP error coming from the remote device
            if (response.StatusCode == HttpStatusCode.InternalServerError)
            {
                if (UPnPError.Parse(response) is UPnPError uPnPError)
                {
                    throw new Exception($"UPnP error: {uPnPError.Code} {uPnPError.Description}.");
                }
            }

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.ReasonPhrase);
            }
        }
    }
}