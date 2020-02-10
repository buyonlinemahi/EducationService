using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class UserPlan
    {
        [DataMember]
        public int UserPlanID { get; set; }
        [DataMember]
        public int PlanID { get; set; }
        [DataMember]
        public int ClientID { get; set; }
        [DataMember]
        public int UserID { get; set; }
        [DataMember]
        public bool? IsPlanApplied { get; set; }
        [DataMember]
        public DateTime? PlanAppliedOn { get; set; }
    }
}
