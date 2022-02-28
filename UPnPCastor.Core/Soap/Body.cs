using System.Reflection;
using System.Xml;
using System.Xml.Serialization;
using UPnPCastor.Core.UPnP.Service;

namespace UPnPCastor.Core.Soap
{
    [Serializable]
    [XmlRoot("Body", Namespace = Envelope.Namespace)]
    public class Body
    {
        public Body() { }

        public Body(UPnP.Service.AVTransport.Action avTransportAction)
        {
            AVTransportAction = avTransportAction;
        }

        [XmlElement(ElementName = nameof(AVTransportAction), Namespace = AVTransportService.Namespace)]
        public UPnP.Service.AVTransport.Action AVTransportAction { get; set; }

        [XmlElement(nameof(Fault), Namespace = Envelope.Namespace)]
        public Fault Fault { get; set; }
    }
}