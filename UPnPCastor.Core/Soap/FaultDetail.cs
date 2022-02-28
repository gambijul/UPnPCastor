using System.Xml.Serialization;
using UPnPCastor.Core.UPnP.Control;

namespace UPnPCastor.Core.Soap
{
    [Serializable]
    [XmlRoot("detail")]
    public class FaultDetail
    {
        [XmlElement("UPnPError", Namespace = "urn:schemas-upnp-org:control-1-0")]
        public UPnPError UPnPError { get; set; }
    }
}