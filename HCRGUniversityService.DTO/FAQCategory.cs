using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class FAQCategory 
    {
        [DataMember]
        public int FAQCatID { get; set; }
        [DataMember]
        public string FAQCategoryTitle { get; set; }
        [DataMember]
        public int OrganizationID { get; set; }
    }
}
