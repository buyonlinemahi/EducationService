using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class EducationFormatAvailable
    {
        [DataMember]
        public int EducationAvailableID { get; set; }
        [DataMember]
        public int EducationID { get; set; }
        [DataMember]
        public int EducationFormatID { get; set; }
        [DataMember]
        public bool IsActive { get; set; }
    }
}