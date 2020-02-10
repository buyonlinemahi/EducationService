using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class EducationNewsSearch
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string DisplayName { get; set; }
        [DataMember]
        public string descriptions { get; set; }
        [DataMember]
        public string NewsType { get; set; }
    }
}