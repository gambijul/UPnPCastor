using System.Xml.Serialization;

namespace UPnPCastor.Core.UPnP.Service.AVTransport.Actions
{
    [Serializable]
    [XmlRoot(nameof(Play))]
    public class Play : Action
    {
        [XmlElement(nameof(Speed), Namespace = null)]
        public int Speed { get; set; } = 1;
    }
}