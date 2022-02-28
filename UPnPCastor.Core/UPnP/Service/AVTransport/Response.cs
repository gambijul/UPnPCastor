using System.Xml;
using System.Xml.Serialization;

namespace UPnPCastor.Core.UPnP.Service.AVTransport
{
    [Serializable]
    public abstract class Response
    {
        [XmlNamespaceDeclarations]
        public XmlSerializerNamespaces xmlns = new(new[]
        {
            new XmlQualifiedName("u", AVTransportService.Namespace)
        });
    }
}