using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class EvaluationQuestionResult
    {
        [DataMember]
        public int EvaluationQuestionResultID { get; set; }
        [DataMember]
        public int EvaluationQuestionID { get; set; }
        [DataMember]
        public int EvaluationAnswerID { get; set; }
        [DataMember]
        public int EvaluationResultID { get; set; }
    }
}
