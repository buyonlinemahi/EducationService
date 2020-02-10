using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class MyEducationModuleDetail
    {
        [DataMember]
        public int EducationModuleID { get; set; }
        [DataMember]
        public int EducationID { get; set; }
        [DataMember]
        public int EducationModulePosition { get; set; }
        [DataMember]
        public int MEMID { get; set; }
        [DataMember]
        public int MEID { get; set; }
        [DataMember]
        public string CourseName { get; set; }
        [DataMember]
        public string CourseFile { get; set; }
        [DataMember]
        public string EducationModuleDescription { get; set; }
        [DataMember]
        public string EducationModuleName { get; set; }
        [DataMember]
        public bool Completed { get; set; }
        [DataMember]
        public DateTime? CompletedDate { get; set; }
        [DataMember]
        public string FileTypeName { get; set; }
        [DataMember]
        public string ModuleFile { get; set; }
        [DataMember]
        public string TimeLeft { get; set; }
        [DataMember]
        public string EducationModuleTime { get; set; }
        [DataMember]
        public int? ExpireDaysLeft { get; set; }
        [DataMember]
        public IEnumerable<EducationModuleFile> EducationModuleFileDetail { get; set; }
        [DataMember]
        public bool? IsTimerRequired { get; set; }   
    }
}