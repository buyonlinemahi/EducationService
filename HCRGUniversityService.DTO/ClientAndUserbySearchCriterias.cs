using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class ClientAndUserbySearchCriterias
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public int OrganizationID { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string EmailID { get; set; }
        [DataMember]
        public string ClientTypeName { get; set; }
        [DataMember]
        public string OrganizationName { get; set; }
        [DataMember]
        public bool? IsActive { get; set; }
    }
}
