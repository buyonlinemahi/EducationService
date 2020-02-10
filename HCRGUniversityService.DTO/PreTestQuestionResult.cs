using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class PreTestQuestionResult
    {
        [DataMember]
        public int PreTestQuestionResultID { get; set; }
        [DataMember]
        public int PreTestQuestionID { get; set; }
        [DataMember]
        public string PreTestAnswer { get; set; }
        [DataMember]
        public int PreTestResultID { get; set; }
        [DataMember]
        public bool? PreTestAnswerTrueFalse { get; set; }
    }
}