using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class ExamQuestionResult
    {
        [DataMember]
        public int ExamQuestionResultID { get; set; }
        [DataMember]
        public int ExamQuestionID { get; set; }
        [DataMember]
        public string ExamAnswer { get; set; }
        [DataMember]
        public int ExamResultID { get; set; }
        [DataMember]
        public bool? ExamAnswerTrueFalse { get; set; }
    }
}