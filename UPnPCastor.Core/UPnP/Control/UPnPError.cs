using System.Xml.Serialization;

namespace UPnPCastor.Core.UPnP.Control
{
    [XmlRoot(nameof(UPnPError), Namespace = "urn:schemas-upnp-org:control-1-0")]
    public class UPnPError
    {
        [XmlElement("errorCode", Namespace = "urn:schemas-upnp-org:control-1-0")]
        public int Code { get; set; }

        [XmlElement("errorDescription", Namespace = "urn:schemas-upnp-org:control-1-0")]
        public string Description { get; set; }
    }
}