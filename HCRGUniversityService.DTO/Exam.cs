using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class Exam : Base.BaseColumn
    {
        [DataMember]
        public int ExamID { get; set; }
        [DataMember]
        public string ExamName { get; set; }
        [DataMember]
        public bool ExamStatus { get; set; }
        [DataMember]
        public string OrganizationName { get; set; }
    }
}
