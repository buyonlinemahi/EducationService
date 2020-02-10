using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class Evaluation : Base.BaseColumn
    {
        [DataMember]
        public int EvaluationID { get; set; }
        [DataMember]
        public string EvaluationName { get; set; }
        [DataMember]
        public bool EvaluationStatus { get; set; }
        [DataMember]
        public string OrganizationName { get; set; }
    }
}
