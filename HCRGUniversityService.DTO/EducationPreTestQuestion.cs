using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class EducationPreTestQuestion
    {
        [DataMember]
        public int CoursePreTestID { get; set; }
        [DataMember]
        public int PreTestID { get; set; }
        [DataMember]
        public int EducationID { get; set; }
        [DataMember]
        public bool? IsActive { get; set; }
    }
}
