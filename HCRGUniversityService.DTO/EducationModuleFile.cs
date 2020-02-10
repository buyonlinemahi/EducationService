using System;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class EducationModuleFile
    {
        [DataMember]
        public int EducationModuleFileID { get; set; }
        [DataMember]
        public int EducationModuleID { get; set; }
        [DataMember]
        public string ModuleFile { get; set; }
        [DataMember]
        public int FileTypeID { get; set; }
        [DataMember]
        public string DocumentName { get; set; }
        [DataMember]
        public DateTime? DocumentUploadedDate { get; set; }
        [DataMember]
        public int? UserID { get; set; }
    }
}
