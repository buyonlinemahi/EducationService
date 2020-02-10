using System;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class Plan : Base.BaseColumn
    {
        [DataMember]
        public int PlanID { get; set; }
        [DataMember]
        public string PlanName { get; set; }
        [DataMember]
        public string OrganizationName { get; set; }
        
    }
}

