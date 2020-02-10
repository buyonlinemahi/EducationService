using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class EducationProfessionDetail
    {
        [DataMember]
        public string CourseName { get; set; }
        [DataMember]
        public string ProfessionTitle { get; set; }
        [DataMember]
        public int EducationProfessionID { get; set; }
        [DataMember]
        public int EducationID { get; set; }
        [DataMember]
        public int ProfessionID { get; set; }
        [DataMember]
        public bool IsActive { get; set; }
    }
}