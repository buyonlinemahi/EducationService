using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class EvaluationQuestionDetail
    {
        [DataMember]
        public int EvaluationQuestionID { get; set; }
        [DataMember]
        public int EvaluationID { get; set; }
        [DataMember]
        public string EvaluationQues { get; set; }
        [DataMember]
        public int CourseEvaluationID { get; set; }
        [DataMember]
        public int EducationID { get; set; }
        [DataMember]
        public string CourseName { get; set; }
    }
}
