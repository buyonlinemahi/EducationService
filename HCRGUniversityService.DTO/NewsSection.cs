using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class NewsSection : Base.BaseColumn
    {
        [DataMember]
        public int NewsSectionID { get; set; }
        [DataMember]
        public string NewsSectionTitle { get; set; }
        [DataMember]
        public string NewsSectionType { get; set; }
    }
}
