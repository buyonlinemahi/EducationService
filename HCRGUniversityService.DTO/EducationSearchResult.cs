using System;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class EducationSearchResult
    {
        [DataMember]
        public string CollegeName { get; set; }
        [DataMember]
        public string CourseName { get; set; }
        [DataMember]
        public DateTime CourseUploadDate { get; set; }
        [DataMember]
        public int NumberOfModule { get; set; }
        [DataMember]
        public int EducationID { get; set; }
        [DataMember]
        public bool? ReadyToDisplay { get; set; }
        [DataMember]
        public bool? IsPublished { get; set; }
        [DataMember]
        public bool? IsCoursePreview { get; set; }
        [DataMember]
        public string OrganizationName { get; set; }
        [DataMember]
        public string ClientName { get; set; }
    }
}