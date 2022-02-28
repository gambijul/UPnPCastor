using System.Xml.Serialization;

namespace UPnPCastor.Core.UPnP.DigitalItemDeclarationLanguage
{
    [Serializable]
    [XmlRoot("res", Namespace = "urn:schemas-upnp-org:metadata-1-0/DIDL-Lite/")]
    public class Resource
    {
        [XmlAttribute("duration")]
        public TimeSpan Duration { get; set; }

        [XmlAttribute("bitrate")]
        public int Bitrate { get; set; }

        [XmlAttribute("resolution")]
        public string Resolution { get; set; }

        [XmlAttribute("protocolInfo")]
        public string ProtocolInfo { get; set; }

        [XmlAttribute("sampleFrequency")]
        public int SampleFrequency { get; set; }

        [XmlAttribute("nrAudioChannels")]
        public int NrAudioChannels { get; set; }

        [XmlAttribute("codec", Namespace = "urn:schemas-microsoft-com:WMPNSS-1-0/")]
        public string Codec { get; set; }

        [XmlText]
        public string Uri { get; set; }

        [XmlAttribute("size")]
        public int Size { get; set; }

        [XmlAttribute("bitsPerSample")]
        public int BitsPerSample { get; set; }
    }
}