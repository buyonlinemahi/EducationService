using System;
using System.Runtime.Serialization;
namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class Event
    {
        [DataMember]
        public int EventID { get; set; }
        [DataMember]
        public string EventName { get; set; }
        [DataMember]
        public DateTime EventDate { get; set; }
        [DataMember]
        public string EventDescription { get; set; }
        [DataMember]
        public int? NewsID { get; set; }
        [DataMember]
        public int? EducationID { get; set; }
        [DataMember]
        public string CourseName { get; set; }
        [DataMember]
        public string NewsTitle { get; set; }
        [DataMember]
        public string NewsType { get; set; }
        [DataMember]
        public DateTime? CourseStartDate { get; set; }
        [DataMember]
        public string CoursePresenterName { get; set; }
        [DataMember]
        public string CourseLocation { get; set; }
        [DataMember]
        public string CourseStartTime { get; set; }
        [DataMember]
        public string OrganizationName { get; set; }
        [DataMember]
        public int OrganizationID { get; set; }
    }
}
