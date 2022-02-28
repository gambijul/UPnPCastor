using System.Xml.Serialization;
using UPnPCastor.Core.UPnP.DigitalItemDeclarationLanguage;

namespace UPnPCastor.Core.UPnP.Service.AVTransport
{
    [Serializable]
    [XmlRoot("CurrentURIMetaData")]
    public class CurrentURIMetaData
    {
        public CurrentURIMetaData() { }

        public CurrentURIMetaData(DIDLLite didlLite)
        {
            Content = didlLite.Serialize();
        }

        [XmlText]
        public string Content { get; set; }
    }
}