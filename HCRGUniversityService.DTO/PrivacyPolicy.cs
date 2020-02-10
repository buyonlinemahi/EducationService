using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class PrivacyPolicy 
    {
        [DataMember]
        public int PrivacyPolicyID { get; set; }
        [DataMember]
        public string PrivacyPolicyContent { get; set; }
        [DataMember]
        public string OrganizationName { get; set; }
        [DataMember]
        public int OrganizationID { get; set; }
    }
}
