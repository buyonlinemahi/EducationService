using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO.Base
{
    [DataContract]
    public class BaseColumn
    {
        [DataMember]
        public int ClientID { get; set; }

        [DataMember]
        public int OrganizationID { get; set; }
    }
}
