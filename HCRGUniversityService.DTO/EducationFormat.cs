using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class EducationFormat  
    {
        [DataMember]
        public int EducationFormatID { get; set; }
        [DataMember]
        public string EducationFormatType { get; set; }
    }
}