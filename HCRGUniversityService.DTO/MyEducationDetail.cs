using System;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class MyEducationDetail
    {
        [DataMember]
        public int MEID { get; set; }
        [DataMember]
        public int UserID { get; set; }
        [DataMember]
        public int EducationID { get; set; }
        [DataMember]
        public int EducationTypeID { get; set; }
        [DataMember]
        public bool Completed { get; set; }
        [DataMember]
        public int TotalModuleCompleted { get; set; }
        [DataMember]
        public int TotalModule { get; set; }
        [DataMember]
        public int percentCompleted { get; set; }
        [DataMember]
        public string CourseFile { get; set; }
        [DataMember]
        public DateTime? CourseCompletedDate { get; set; }
        [DataMember]
        public string CourseName { get; set; }
        [DataMember]
        public bool? IsPassed { get; set; }
        [DataMember]
        public int? CredentialID { get; set; }
        [DataMember]
        public bool? Expired { get; set; }
        [DataMember]
        public bool? CertificatePrinted { get; set; }
        [DataMember]
        public string CertificateURL { get; set; }
        [DataMember]
        public DateTime? ExpiryDate { get; set; }
        [DataMember]
        public bool AllowRevisit { get; set; }
        [DataMember]
        public int PlanID { get; set; }
    }
}