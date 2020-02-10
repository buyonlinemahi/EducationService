using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class CarouselSetUp : Base.BaseColumn
    {
        [DataMember]
        public int CarouselID { get; set; }
        [DataMember]
        public string CarouselTitle { get; set; }
        [DataMember]
        public string CarouselDescription { get; set; }
        [DataMember]
        public string CarouselBgColor { get; set; }
        [DataMember]
        public int NewsID { get; set; }
        [DataMember]
        public string NewsTitle { get; set; }
        [DataMember]
        public string NewsDescription { get; set; }
        [DataMember]
        public string NewsPhotoUrl { get; set; }
        [DataMember]
        public string NewsType { get; set; }
        [DataMember]
        public string OrganizationName { get; set; }


       
       
       

    }
}
