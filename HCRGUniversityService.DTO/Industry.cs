using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class Industry
    {
        [DataMember]
        public int IndustryID { get; set; }
        [DataMember]
        public string IndustryName { get; set; }
    }
}
