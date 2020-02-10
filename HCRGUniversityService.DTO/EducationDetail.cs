using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class EducationDetail
    {
        [DataMember]
        public int CollegeID { get; set; }
        [DataMember]
        public int CollegeCourseID { get; set; }
        [DataMember]
        public string CollegeName { get; set; }
        [DataMember]
        public int EducationID { get; set; }
        [DataMember]
        public string CourseName { get; set; }
        [DataMember]
        public string CourseCode { get; set; }
        [DataMember]
        public string CourseDescription { get; set; }
        [DataMember]
        public string CourseTime { get; set; }
        [DataMember]
        public DateTime CourseUploadDate { get; set; }
        [DataMember]
        public decimal CoursePrice { get; set; }
        [DataMember]
        public bool IsActive { get; set; }
        [DataMember]
        public DateTime? CourseStartDate { get; set; }
        [DataMember]
        public DateTime? CourseEndDate { get; set; }
        [DataMember]
        public int? CourseAllotedTime { get; set; }
        [DataMember]
        public string CouseAllotedDaysMonth { get; set; }
        [DataMember]
        public IEnumerable<EducationFormat> EducationFormat { get; set; }
        [DataMember]
        public bool? IsPublished { get; set; }
        [DataMember]
        public bool? IsTimerRequired { get; set; }
        [DataMember]
        public bool? IsCoursePreview { get; set; }
    }
}