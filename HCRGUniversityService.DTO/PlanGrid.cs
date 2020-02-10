using System;
using System.Runtime.Serialization;
namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class PlanGrid
    {
        [DataMember]
        public int PlanID { get; set; }
        [DataMember]
        public string PlanName { get; set; }
        [DataMember]
        public int ClientID { get; set; }
        [DataMember]
        public string OrganizationName { get; set; }
        [DataMember]
        public int OrganizationID { get; set; }
    }
}
