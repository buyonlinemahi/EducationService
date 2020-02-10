using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class EvaluationResult
    {
        [DataMember]
        public int UID { get; set; }
        [DataMember]
        public int EvaluationResultID { get; set; }
        [DataMember]
        public bool IsPass { get; set; }
        [DataMember]
        public int MEID { get; set; }
        [DataMember]
        public int EvaluationID { get; set; }
        [DataMember]
        public string Comments { get; set; }
        [DataMember]
        public string Suggestions { get; set; }
    }
}
