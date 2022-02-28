using System.Xml;
using System.Xml.Serialization;
using UPnPCastor.Core.IO;

namespace UPnPCastor.Core.Soap
{
    [Serializable]
    [XmlRoot("s:Envelope")]
    public class Envelope
    {
        public const string Namespace = "http://schemas.xmlsoap.org/soap/envelope/";

        [XmlNamespaceDeclarations]
        public XmlSerializerNamespaces xmlns = new(new[]
        {
            new XmlQualifiedName("s", Namespace)
        });

        [XmlElement(nameof(Body), Namespace = Namespace)]
        public Body Body { get; set; }

        [XmlAttribute("encodingStyle", Namespace = Namespace)]
        public string EncodingStyle { get; set; } = "http://schemas.xmlsoap.org/soap/encoding/";

        public string Serialize()
        {
            XmlSerializerNamespaces namespaces = new();
            namespaces.Add(string.Empty, string.Empty);

            XmlWriterSettings xmlWriterSettings = new() { Indent = true };

            using StringWriterUtf8 stringWriter = new();
            using XmlWriter xmlWriter = XmlWriter.Create(stringWriter, xmlWriterSettings);

            new XmlSerializer(GetType()).Serialize(xmlWriter, this, namespaces);

            return stringWriter.ToString()!
                .Replace("_x003A_", ":")
                .Replace(nameof(Body.Action), Body.Action.GetType().Name);
        }
    }
}