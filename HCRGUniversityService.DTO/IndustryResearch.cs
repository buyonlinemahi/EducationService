using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class IndustryResearch : Base.BaseColumn
    {
        [DataMember]
        public int IndustryResearchID { get; set; }
        [DataMember]
        public string IndustryResearchContent { get; set; }
        [DataMember]
        public string OrganizationName { get; set; }
    }
}
