using System.Xml.Serialization;

namespace UPnPCastor.Core.UPnP.Service.AVTransport.Responses
{
    [XmlRoot(nameof(GetPositionInfoResponse), Namespace = AVTransportService.Namespace)]
    public class GetPositionInfoResponse : Response
    {
        [XmlElement(nameof(Track), Namespace = "")]
        public int Track { get; set; }

        [XmlElement(nameof(TrackDuration), Namespace = "")]
        public DateTime TrackDuration { get; set; }

        [XmlElement(nameof(TrackURI), Namespace = "")]
        public string TrackURI { get; set; }

        [XmlElement(nameof(RelTime), Namespace = "")]
        public DateTime RelTime { get; set; }

        [XmlElement(nameof(AbsTime), Namespace = "")]
        public string AbsTime { get; set; }

        [XmlElement(nameof(RelCount), Namespace = "")]
        public int RelCount { get; set; }

        [XmlElement(nameof(AbsCount), Namespace = "")]
        public int AbsCount { get; set; }
    }
}