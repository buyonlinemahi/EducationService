using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public  class EducationEvaluation
    {
        [DataMember]
        public int CourseEvaluationID { get; set; }
        [DataMember]
        public int EvaluationID { get; set; }
        [DataMember]
        public int EducationID { get; set; }
        [DataMember]
        public bool? IsActive { get; set; }
    }
}
