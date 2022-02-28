using System.Xml.Serialization;

namespace UPnPCastor.Core.Soap
{
    [Serializable]
    [XmlRoot(nameof(Fault), Namespace = Envelope.Namespace)]
    public class Fault
    {
        [XmlElement("faultcode", Namespace = "")]
        public string Code { get; set; }

        [XmlElement("faultstring", Namespace = "")]
        public string Message { get; set; }

        [XmlElement("detail", Namespace = "")]
        public FaultDetail Detail { get; set; }
    }
}