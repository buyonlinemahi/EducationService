using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class TermsCondition : Base.BaseColumn   
    {
        [DataMember]
        public int TermsConditionID { get; set; }
        [DataMember]
        public string TermsConditionContent { get; set; }
        [DataMember]
        public string OrganizationName { get; set; }
    }
}
