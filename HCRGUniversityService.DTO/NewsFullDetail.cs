using System;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class NewsFullDetail
    {
        [DataMember]
        public int NewsID { get; set; }
        [DataMember]
        public int NewsSectionID { get; set; }
        [DataMember]
        public string NewsTitle { get; set; }
        [DataMember]
        public string NewsDescription { get; set; }
        [DataMember]
        public string NewsType { get; set; }
        [DataMember]
        public bool NewsEditorPick { get; set; }
        [DataMember]
        public DateTime NewsDate { get; set; }
        [DataMember]
        public string NewsSectionTitle { get; set; }
        [DataMember]
        public int PhotoVideoId { get; set; }
        [DataMember]
        public string PhotoVideoTitle { get; set; }
        [DataMember]
        public string NewsAuthor { get; set; }
    }
}
