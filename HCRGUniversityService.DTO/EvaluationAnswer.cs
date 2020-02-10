using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
   public class EvaluationAnswer
   {
       [DataMember]
        public int EvaluationAnswerID { get; set; }
         [DataMember]
        public string EvaluationAns { get; set; }
    }
}
