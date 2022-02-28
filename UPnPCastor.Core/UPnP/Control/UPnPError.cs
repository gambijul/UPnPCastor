using System.Xml.Serialization;
using UPnPCastor.Core.Soap;

namespace UPnPCastor.Core.UPnP.Control
{
    [XmlRoot(nameof(UPnPError), Namespace = "urn:schemas-upnp-org:control-1-0")]
    public class UPnPError
    {
        [XmlElement("errorCode", Namespace = "urn:schemas-upnp-org:control-1-0")]
        public int Code { get; set; }

        [XmlElement("errorDescription", Namespace = "urn:schemas-upnp-org:control-1-0")]
        public string Description { get; set; }

        public static UPnPError? Parse(HttpResponseMessage response)
        {
            string errorContent = response.Content.ReadAsStringAsync().Result;
            XmlSerializer serializer = new(typeof(EnvelopeError));
            using StringReader reader = new(errorContent);
            EnvelopeError? envelopeError = serializer.Deserialize(reader) as EnvelopeError;
            return envelopeError?.Body.Fault.Detail.UPnPError;
        }
    }
}