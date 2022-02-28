using System.Xml.Serialization;

namespace UPnPCastor.Core.Soap
{
    [Serializable]
    [XmlRoot(ElementName = "Envelope", Namespace = Envelope.Namespace)]
    public class EnvelopeResponse
    {

        [XmlElement(nameof(Body), Namespace = Envelope.Namespace)]
        public Body Body { get; set; }

        [XmlAttribute("encodingStyle", Namespace = Envelope.Namespace)]
        public string EncodingStyle { get; set; }

        [XmlAttribute("s")]
        public string S { get; set; }
    }
}