using System;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class News : Base.BaseColumn
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
        public bool NewsEditorPick { get; set; }
        [DataMember]
        public string NewsType { get; set; }
        [DataMember]
        public DateTime NewsDate { get; set; }
        [DataMember]
        public string NewsAuthor { get; set; }
        [DataMember]
        public string OrganizationName { get; set; }
    }
}
