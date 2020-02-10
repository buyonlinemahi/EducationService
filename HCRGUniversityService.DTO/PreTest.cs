using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class PreTest : Base.BaseColumn
  {
          [DataMember]
        public int PreTestID { get; set; }
         [DataMember]
        public string PreTestName { get; set; }
         [DataMember]
        public bool PreTestStatus { get; set; }
        [DataMember]
         public string OrganizationName { get; set; }
    }
}
