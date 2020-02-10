using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class PreTestResult
    {
        [DataMember]
        public int PreTestResultID { get; set; }
        [DataMember]
        public int UID { get; set; }
        [DataMember]
        public bool IsPass { get; set; }
        [DataMember]
        public int MEID { get; set; }
        [DataMember]
        public int PreTestID { get; set; }
    }
}