using System;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class SuggestCourse : Base.BaseColumn
    {
        [DataMember]
        public int SuggestCourseID { get; set; }
        [DataMember]
        public string SCMyOccupation { get; set; }
        [DataMember]
        public int SCStateID { get; set; }
        [DataMember]
        public string SCName { get; set; }
        [DataMember]
        public string SCPhone { get; set; }
        [DataMember]
        public string SCEmail { get; set; }
        [DataMember]
        public string SCPossibleTitle { get; set; }
        [DataMember]
        public string SCBriefAgendaOutline { get; set; }
        [DataMember]
        public string SCAudience { get; set; }
        [DataMember]
        public bool? SCSingleDaySeminarCourse { get; set; }
        [DataMember]
        public bool? SCOndemandLiveWebinarCourse { get; set; }
        [DataMember]
        public bool? SCInterestedInstructor { get; set; }
        [DataMember]
        public DateTime? SCCreatedDate { get; set; }
        [DataMember]
        public string OrganizationName { get; set; }
    }
}
