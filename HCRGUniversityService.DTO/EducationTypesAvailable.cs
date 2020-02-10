using System;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
     [DataContract]
    public class EducationTypesAvailable
    {
        [DataMember]
        public int EducationTypeAID { get; set; }
        [DataMember]
        public int EducationID { get; set; }
        [DataMember]
        public int EducationTypeID { get; set; }
        [DataMember]
        public decimal Price { get; set; }
    }
}
