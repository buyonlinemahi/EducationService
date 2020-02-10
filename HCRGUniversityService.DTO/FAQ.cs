using System.Runtime.Serialization;
namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class FAQ : Base.BaseColumn
    {
        [DataMember]
        public int FAQID { get; set; }
        [DataMember]
        public int FAQCatID { get; set; }
        [DataMember]
        public string FAQues { get; set; }
        [DataMember]
        public string FAQAns { get; set; }
        [DataMember]
        public string FAQCategoryTitle { get; set; }
        [DataMember]
        public string OrganizationName { get; set; }
        [DataMember]
        public string FaqCategoryName { get; set; }
    }   
}
