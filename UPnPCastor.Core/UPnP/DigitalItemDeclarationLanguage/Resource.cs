using System.Xml.Serialization;

namespace UPnPCastor.Core.UPnP.DigitalItemDeclarationLanguage
{
    [Serializable]
    [XmlRoot("res", Namespace = "urn:schemas-upnp-org:metadata-1-0/DIDL-Lite/")]
    public class Resource
    {
        [XmlIgnore] // Not mandatory
        [XmlAttribute("duration")]
        public TimeSpan Duration { get; set; }

        [XmlIgnore] // Not mandatory
        [XmlAttribute("bitrate")]
        public int Bitrate { get; set; }

        [XmlIgnore] // Not mandatory
        [XmlAttribute("resolution")]
        public string Resolution { get; set; }

        [XmlAttribute("protocolInfo")]
        public string ProtocolInfo { get; set; }

        [XmlIgnore] // Not mandatory
        [XmlAttribute("sampleFrequency")]
        public int SampleFrequency { get; set; }

        [XmlIgnore] // Not mandatory
        [XmlAttribute("nrAudioChannels")]
        public int NrAudioChannels { get; set; }

        [XmlIgnore] // Not mandatory
        [XmlAttribute("codec", Namespace = "urn:schemas-microsoft-com:WMPNSS-1-0/")]
        public string Codec { get; set; }

        [XmlText]
        public string Uri { get; set; }

        [XmlIgnore] // Not mandatory
        [XmlAttribute("size")]
        public int Size { get; set; }

        [XmlIgnore] // Not mandatory
        [XmlAttribute("bitsPerSample")]
        public int BitsPerSample { get; set; }
    }
}