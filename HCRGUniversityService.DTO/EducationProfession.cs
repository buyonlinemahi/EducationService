using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class EducationProfession
    {
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