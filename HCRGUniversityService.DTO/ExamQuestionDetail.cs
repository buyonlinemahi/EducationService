using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class ExamQuestionDetail
    {
        [DataMember]
        public int EducationID { get; set; }
        [DataMember]
        public string ExamQues { get; set; }
        [DataMember]
        public string ExamOptionA { get; set; }
        [DataMember]
        public string ExamOptionB { get; set; }
        [DataMember]
        public string ExamOptionC { get; set; }
        [DataMember]
        public string ExamOptionD { get; set; }
        [DataMember]
        public string ExamAnswer { get; set; }
        [DataMember]
        public int ExamID { get; set; }
        [DataMember]
        public int ExamQuestionID { get; set; }
        [DataMember]
        public string ExamAnswerType { get; set; }
        [DataMember]
        public bool? ExamAnswerTrueFalse { get; set; }
    }
}
