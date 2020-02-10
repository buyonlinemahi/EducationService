using HCRGUniversityService.DTO.Base;
using System;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class Education : BaseColumn
    {
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
        public bool CourseCredential { get; set; }
        [DataMember]
        public DateTime CourseUploadDate { get; set; }
        [DataMember]
        public decimal CoursePrice { get; set; }
        [DataMember]
        public bool IsActive { get; set; }
        [DataMember]
        public string CourseFile { get; set; }
        [DataMember]
        public DateTime? CourseStartDate { get; set; }
        [DataMember]
        public DateTime? CourseEndDate { get; set; }
        [DataMember]
        public string CoursePresenterName { get; set; }
        [DataMember]
        public string CourseLocation { get; set; }
        [DataMember]
        public string CourseStartTime { get; set; }
        [DataMember]
        public string CourseEndTime { get; set; }
        [DataMember]
        public DateTime? CourseDate { get; set; }
        [DataMember]
        public int? CourseAllotedTime { get; set; }
        [DataMember]
        public string CouseAllotedDaysMonth { get; set; }
        [DataMember]
        public bool? ReadyToDisplay { get; set; }
        [DataMember]
        public bool? AllowRevisit { get; set; }
        [DataMember]
        public bool? IsPublished { get; set; }
        [DataMember]
        public bool? IsTimerRequired { get; set; }
        [DataMember]
        public bool? IsProgramRequired { get; set; }
        [DataMember]
        public int? StateID { get; set; }
        [DataMember]
        public bool? IsCoursePreview { get; set; }
        [DataMember]
        public int IndustryID { get; set; }
        [DataMember]
        public string OrganizationName { get; set; }

    }
}