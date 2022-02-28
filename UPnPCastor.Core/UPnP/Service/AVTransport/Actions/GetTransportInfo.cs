using System.Xml.Serialization;

namespace UPnPCastor.Core.UPnP.Service.AVTransport.Actions
{
    [Serializable]
    [XmlRoot(nameof(GetTransportInfo))]
    public class GetTransportInfo : Action { }
}