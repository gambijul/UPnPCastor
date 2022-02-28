using System.Xml;
using System.Xml.Serialization;
using UPnPCastor.Core.UPnP.Service.AVTransport.Actions;

namespace UPnPCastor.Core.UPnP.Service.AVTransport
{
    [Serializable]
    [XmlInclude(typeof(GetMediaInfo))]
    [XmlInclude(typeof(GetPositionInfo))]
    [XmlInclude(typeof(GetTransportInfo))]
    [XmlInclude(typeof(Pause))]
    [XmlInclude(typeof(Play))]
    [XmlInclude(typeof(SetAVTransportURI))]
    [XmlInclude(typeof(Stop))]
    [XmlRoot(Namespace = AVTransportService.Namespace)]
    public abstract class Action
    {
        [XmlNamespaceDeclarations]
        public XmlSerializerNamespaces xmlns = new(new[]
        {
            new XmlQualifiedName("m", AVTransportService.Namespace)
        });

        [XmlElement(nameof(InstanceID), Namespace = null)]
        public int InstanceID { get; set; } = 0;
    }
}