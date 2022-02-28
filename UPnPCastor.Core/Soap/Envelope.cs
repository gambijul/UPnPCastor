using System.Xml;
using System.Xml.Serialization;

namespace UPnPCastor.Core.Soap
{
    [Serializable]
    [XmlRoot("SOAP-ENV:Envelope")]
    public class Envelope
    {
        public const string Namespace = "http://schemas.xmlsoap.org/soap/envelope/";

        [XmlNamespaceDeclarations]
        public XmlSerializerNamespaces xmlns = new(new[]
        {
            new XmlQualifiedName("SOAP-ENV", Namespace)
        });

        [XmlElement(nameof(Body), Namespace = Namespace)]
        public Body Body { get; set; }

        [XmlAttribute("encodingStyle", Namespace = Namespace)]
        public string EncodingStyle { get; set; } = "http://schemas.xmlsoap.org/soap/encoding/";

        public string Serialize()
        {
            XmlSerializerNamespaces namespaces = new();
            namespaces.Add(string.Empty, string.Empty);

            using StringWriter stringWriter = new();
            using XmlWriter xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true, OmitXmlDeclaration = true });

            stringWriter.WriteLine("<?xml version=\"1.0\"?>");
            new XmlSerializer(GetType()).Serialize(xmlWriter, this, namespaces, null);

            return stringWriter.ToString()!
                .Replace("_x003A_", ":")
                .Replace(nameof(Body.Action), Body.Action.GetType().Name);
        }
    }
}