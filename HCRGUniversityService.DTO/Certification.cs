using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class Certification : Base.BaseColumn
    {
        [DataMember]
        public int CertificationID { get; set; }
        [DataMember]
        public string CertificationContent { get; set; }
        [DataMember]
        public string OrganizationName { get; set; }
    }
}
