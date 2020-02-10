using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class CertificationTitleOption
    {
        [DataMember]
        public int CertificationTitleOptionID { get; set; }
        [DataMember]
        public string CertificationTitle { get; set; }
        [DataMember]
        public string CertificationContent { get; set; }
        [DataMember]
        public int EducationId { get; set; }
        [DataMember]
        public string CourseName { get; set; }
    }
}
