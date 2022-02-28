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
                            Duration = new TimeSpan(0, 0, 9, 56, 480),
                            Bitrate = 1556918,
                            Resolution = "1920x1080",
                            ProtocolInfo = new ProtocolInfo(uri).ToString(),
                            SampleFrequency = 48000,
                            BitsPerSample = 16,
                            NrAudioChannels = 5,
                            Codec = "{5634504D-0000-0010-8000-00AA00389B71}",
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