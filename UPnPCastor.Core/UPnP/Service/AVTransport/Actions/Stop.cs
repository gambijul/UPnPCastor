using System.Xml.Serialization;

namespace UPnPCastor.Core.UPnP.Service.AVTransport.Actions
{
    [Serializable]
    [XmlRoot(nameof(Stop))]
    public class Stop : Action { }
}