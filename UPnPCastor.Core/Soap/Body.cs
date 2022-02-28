using System.Xml;
using System.Xml.Serialization;
using UPnPCastor.Core.UPnP.Service;
using UPnPCastor.Core.UPnP.Service.AVTransport;
using UPnPCastor.Core.UPnP.Service.AVTransport.Responses;

namespace UPnPCastor.Core.Soap
{
    [Serializable]
    [XmlRoot(nameof(Body), Namespace = Envelope.Namespace)]
    public class Body
    {
        public Body() { }

        public Body(UPnP.Service.AVTransport.Action avTransportAction)
        {
            Action = avTransportAction;
        }

        [XmlElement(nameof(Action), Namespace = AVTransportService.Namespace)]
        public UPnP.Service.AVTransport.Action Action { get; set; }

        [XmlElement("GetPositionInfoResponse", typeof(GetPositionInfoResponse), Namespace = AVTransportService.Namespace)]
        public Response Response { get; set; }

        [XmlElement(nameof(Fault), Namespace = Envelope.Namespace)]
        public Fault Fault { get; set; }

        public static Fault? ParseFault(HttpResponseMessage response)
        {
            string errorContent = response.Content.ReadAsStringAsync().Result;
            XmlSerializer serializer = new(typeof(EnvelopeResponse));
            using StringReader reader = new(errorContent);
            EnvelopeResponse? envelopeError = serializer.Deserialize(reader) as EnvelopeResponse;
            return envelopeError?.Body.Fault;
        }

        public static Response? ParseResponse(HttpResponseMessage response)
        {
            string errorContent = response.Content.ReadAsStringAsync().Result;
            XmlSerializer serializer = new(typeof(EnvelopeResponse));
            using StringReader reader = new(errorContent);
            EnvelopeResponse? envelopeResponse = serializer.Deserialize(reader) as EnvelopeResponse;
            return envelopeResponse?.Body.Response;
        }
    }
}