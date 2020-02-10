using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class ReturnPolicy : Base.BaseColumn
    {
        [DataMember]
        public int ReturnPolicyID { get; set; }
        [DataMember]
        public string ReturnPolicyContent { get; set; }
        [DataMember]
        public string OrganizationName { get; set; }
    }
}
