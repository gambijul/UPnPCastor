using System.Xml.Serialization;

namespace UPnPCastor.Core.UPnP.Service.AVTransport.Actions
{
    [Serializable]
    [XmlRoot(nameof(GetMediaInfo))]
    public class GetMediaInfo : Action { }
}