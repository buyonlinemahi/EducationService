using System;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class CertificateDetail
    {
        [DataMember]
        public string CourseName { get; set; }
        [DataMember]
        public DateTime CompletedDate { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string CertificateMessage { get; set; }
        [DataMember]
        public string AccreditorName { get; set; }
        [DataMember]
        public decimal? CredentialUnit { get; set; }
        [DataMember]
        public string CredentialProgram { get; set; }
    }
}
