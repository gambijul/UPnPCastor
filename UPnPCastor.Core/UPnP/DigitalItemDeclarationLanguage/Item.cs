using System.Xml.Serialization;

namespace UPnPCastor.Core.UPnP.DigitalItemDeclarationLanguage
{
    [Serializable]
    [XmlRoot("item", Namespace = "urn:schemas-upnp-org:metadata-1-0/DIDL-Lite/")]
    public class Item
    {
        [XmlElement("title", Namespace = "http://purl.org/dc/elements/1.1/")]
        public string Title { get; set; }

        [XmlElement("res", Namespace = "urn:schemas-upnp-org:metadata-1-0/DIDL-Lite/")]
        public List<Resource> Resources { get; set; }

        [XmlElement("class", Namespace = "urn:schemas-upnp-org:metadata-1-0/upnp/")]
        public string Class { get; set; }

        [XmlElement("albumArtURI", Namespace = "urn:schemas-upnp-org:metadata-1-0/upnp/")]
        public string AlbumArtURI { get; set; }

        [XmlAttribute("id")]
        public int Id { get; set; } = 1000;

        [XmlAttribute("restricted")]
        public int Restricted { get; set; } = 1;

        [XmlAttribute("parentID")]
        public int ParentID { get; set; } = 0;
    }
}