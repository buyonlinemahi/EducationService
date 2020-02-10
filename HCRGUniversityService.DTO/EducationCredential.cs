using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class EducationCredential
    {
        [DataMember]
        public int CredentialID { get; set; }
        [DataMember]
        public decimal? CredentialUnit { get; set; }
        [DataMember]
        public string CredentialProgram { get; set; }
        [DataMember]
        public int AccreditorID { get; set; }
        [DataMember]
        public string CertificateMessage { get; set; }
        [DataMember]
        public int EducationID { get; set; }
        [DataMember]
        public bool IsActive { get; set; }
        [DataMember]
        public string AccreditorName { get; set; }
        [DataMember]
        public string CredentialType { get; set; }
    }
}