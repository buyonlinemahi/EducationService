using System;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class EnterprisePackageRegister 
    {
        [DataMember]
        public int EPRID { get; set; }
        [DataMember]
        public string EPRName { get; set; }
        [DataMember]
        public string EPRPhone { get; set; }
        [DataMember]
        public string EPREmail { get; set; }
        [DataMember]
        public string EPRCompany { get; set; }
        [DataMember]
        public DateTime? EPRCreatedDate { get; set; }
        [DataMember]
        public int OrganizationID { get; set; }
        [DataMember]
        public string OrganizationName { get; set; }
    }
}
