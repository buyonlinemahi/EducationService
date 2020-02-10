using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class DeliveryTerm : Base.BaseColumn
    {
        [DataMember]
        public int DeliveryTermID { get; set; }
        [DataMember]
        public string DeliveryTermContents { get; set; }
        [DataMember]
        public string OrganizationName { get; set; }
    }
}
