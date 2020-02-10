using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class Resource : Base.BaseColumn
    {
        [DataMember]
        public int ResourceID { get; set; }
        [DataMember]
        public string ResourceTitle { get; set; }
    }
}
