using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class ExamResult
    {
        [DataMember]
        public int ExamResultID { get; set; }
        [DataMember]
        public int UID { get; set; }
        [DataMember]
        public bool IsPass { get; set; }
        [DataMember]
        public int MEID { get; set; }
        [DataMember]
        public int ExamID { get; set; }
    }
}
