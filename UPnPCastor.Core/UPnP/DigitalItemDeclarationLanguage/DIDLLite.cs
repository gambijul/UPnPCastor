using System.Xml;
using System.Xml.Serialization;

namespace UPnPCastor.Core.UPnP.DigitalItemDeclarationLanguage
{
    [Serializable]
    [XmlRoot("DIDL-Lite", Namespace = Namespace)]
    public class DIDLLite
    {
        public const string Namespace = "urn:schemas-upnp-org:metadata-1-0/DIDL-Lite/";

        [XmlNamespaceDeclarations]
        public XmlSerializerNamespaces xmlns = new(new[]
        {
            new XmlQualifiedName("dc", "http://purl.org/dc/elements/1.1/"),
            new XmlQualifiedName("upnp", "urn:schemas-upnp-org:metadata-1-0/upnp/"),
            new XmlQualifiedName("microsoft", "urn:schemas-microsoft-com:WMPNSS-1-0/"),
            new XmlQualifiedName("dlna", "urn:schemas-dlna-org:metadata-1-0/")
        });

        [XmlElement("item", Namespace = "urn:schemas-upnp-org:metadata-1-0/DIDL-Lite/")]
        public Item Item { get; set; }

        public string Serialize()
        {
            XmlSerializerNamespaces namespaces = new();
            namespaces.Add(string.Empty, string.Empty);

            using StringWriter stringWriter = new();
            using XmlWriter xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { OmitXmlDeclaration = true });

            new XmlSerializer(GetType()).Serialize(xmlWriter, this, namespaces, null);

            return stringWriter.ToString();
        }
    }
}