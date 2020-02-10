using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class TrainingAndSeminar : Base.BaseColumn
    {
        [DataMember]
        public int TrainingAndSeminarID { get; set; }
        [DataMember]
        public string TrainingAndSeminarDesc { get; set; }
        [DataMember]
        public string OrganizationName { get; set; }
    }
}
