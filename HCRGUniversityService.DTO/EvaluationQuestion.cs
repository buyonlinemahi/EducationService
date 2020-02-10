using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class EvaluationQuestion
    {
        [DataMember]
        public int EvaluationQuestionID { get; set; }
        [DataMember]
        public int EvaluationID { get; set; }
        [DataMember]
        public string EvaluationQues { get; set; }
        [DataMember]
        public bool IsStatus { get; set; }
    }
}
