using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class NewsLetter : Base.BaseColumn
    {
        [DataMember]
        public int NewsLetterID { get; set; }
        [DataMember]
        public string NewsLetterContent { get; set; }
        [DataMember]
        public string OrganizationName { get; set; }
    }
}
