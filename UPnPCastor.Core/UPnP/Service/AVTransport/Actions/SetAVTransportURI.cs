using System.Xml;
using System.Xml.Serialization;
using UPnPCastor.Core.UPnP.DigitalItemDeclarationLanguage;

namespace UPnPCastor.Core.UPnP.Service.AVTransport.Actions
{
    [Serializable]
    [XmlRoot(nameof(SetAVTransportURI))]
    public class SetAVTransportURI : Action
    {
        public SetAVTransportURI() { }

        public SetAVTransportURI(string uri)
        {
            CurrentURI = uri;
            CurrentURIMetaData = new(new DIDLLite()
            {
                Item = new()
                {
                    Title = Path.GetFileNameWithoutExtension(uri),
                    Resources = new()
                    {
                        new Resource()
                        {
                            ProtocolInfo = new ProtocolInfo(uri).ToString(),
                            Uri = uri.ToString()
                        }
                    },
                    Class = "object.item.videoItem"
                }
            });
        }

        [XmlElement("CurrentURI")]
        public string CurrentURI { get; set; }

        [XmlElement("CurrentURIMetaData")]
        public CurrentURIMetaData CurrentURIMetaData { get; set; }
    }
}