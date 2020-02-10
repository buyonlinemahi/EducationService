using System;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class EducationDetailPage
    {
        [DataMember]
        public int EPageID { get; set; }
        [DataMember]
        public int EducationID { get; set; }
        [DataMember]
        public string PContent { get; set; }
        [DataMember]
        public DateTime PDate { get; set; }
    }
}