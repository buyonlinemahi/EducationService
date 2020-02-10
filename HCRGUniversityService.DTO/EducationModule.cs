using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class EducationModule
    {
        [DataMember]
        public int EducationModuleID { get; set; }
        [DataMember]
        public int EducationID { get; set; }
        [DataMember]
        public string EducationModuleName { get; set; }
        [DataMember]
        public string EducationModuleDescription { get; set; }
        [DataMember]
        public string EducationModuleTime { get; set; }
        [DataMember]
        public DateTime EducationModuleDate { get; set; }
        [DataMember]
        public int EducationModulePosition { get; set; }
        [DataMember]
        public int FileTypeID { get; set; }
        [DataMember]
        public string ModuleFile { get; set; }
    }
}
