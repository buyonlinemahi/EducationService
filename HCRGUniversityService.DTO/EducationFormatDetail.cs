using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class EducationFormatDetail
    {
        [DataMember]
        public string CourseName { get; set; }
        [DataMember]
        public string EducationFormatType { get; set; }
        [DataMember]
        public int EducationPriority { get; set; }
        [DataMember]
        public int EducationAvailableID { get; set; }
        [DataMember]
        public int EducationFormatID { get; set; }
        [DataMember]
        public int EducationID { get; set; }
        [DataMember]
        public bool IsActive { get; set; }
    }
}