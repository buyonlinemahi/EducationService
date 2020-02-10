using System.Runtime.Serialization;
namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class ClientType
    {
        [DataMember]
        public int ClientTypeID { get; set; }
        [DataMember]
        public string ClientTypeName { get; set; }
    }
}
