using System.Xml.Serialization;

namespace UPnPCastor.Core.UPnP.Service.AVTransport.Actions
{
    [Serializable]
    [XmlRoot(nameof(Pause))]
    public class Pause : Action { }
}