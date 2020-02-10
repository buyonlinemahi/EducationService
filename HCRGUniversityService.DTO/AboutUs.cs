using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class AboutUs : Base.BaseColumn
    {
        [DataMember]
        public int AboutUsID { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string OrganizationName { get; set; }
    }
}
