using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class PreTestQuestion
    {
        [DataMember]
        public int PreTestQuestionID { get; set; }
        [DataMember]
        public string PreTestQues { get; set; }
        [DataMember]
        public string PreTestOptionA { get; set; }
        [DataMember]
        public string PreTestOptionB { get; set; }
        [DataMember]
        public string PreTestOptionC { get; set; }
        [DataMember]
        public string PreTestOptionD { get; set; }
        [DataMember]
        public string PreTestAnswer { get; set; }
        [DataMember]
        public int PreTestID { get; set; }
        [DataMember]
        public string PreTestAnswerType { get; set; }
        [DataMember]
        public bool? PreTestAnswerTrueFalse { get; set; }
    }
}
