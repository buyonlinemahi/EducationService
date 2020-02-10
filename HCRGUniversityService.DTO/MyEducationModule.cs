using System;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class MyEducationModule
    {
        [DataMember]
        public int MEMID { get; set; }
        [DataMember]
        public int EducationModuleID { get; set; }
        [DataMember]
        public int MEID { get; set; }
        [DataMember]
        public bool Completed { get; set; }
        [DataMember]
        public DateTime? CompletedDate { get; set; }
        [DataMember]
        public string TimeLeft { get; set; }
    }
}
