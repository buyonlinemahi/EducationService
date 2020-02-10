using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class NewsVideo
    {
        [DataMember]
        public int NewsVideoID { get; set; }
        [DataMember]
        public int NewsID { get; set; }
        [DataMember]
        public string NewsVideos { get; set; }

    }
}
