using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HCRGUniversityService.DTO
{
     [DataContract]
    public class CoursePlan
    {
        [DataMember]
        public int CoursePlanID { get; set; }
        [DataMember]
        public int PlanID { get; set; }
        [DataMember]
        public int ClientID { get; set; }
        [DataMember]
        public int CourseID { get; set; }
    }
}
