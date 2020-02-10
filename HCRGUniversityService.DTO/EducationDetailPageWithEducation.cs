using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class EducationDetailPageWithEducation
    {
        [DataMember]
        public int EPageID { get; set; }
        [DataMember]
        public int EducationID { get; set; }
        [DataMember]
        public string PContent { get; set; }
        [DataMember]
        public DateTime PDate { get; set; }
        [DataMember]
        public string CourseName { get; set; }
    }
}
