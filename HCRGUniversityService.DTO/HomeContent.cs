using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class HomeContent : Base.BaseColumn
    {
        [DataMember]
        public int HomeContentID { get; set; }
        [DataMember]
        public string HomePageContent { get; set; }
        [DataMember]
        public string OrganizationName { get; set; }
    }
}
