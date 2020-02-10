using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class NewsSearchCarousel
    {
        [DataMember]
        public int NewsID { get; set; }
        [DataMember]
        public int NewsSectionID { get; set; }
        [DataMember]
        public string NewsTitle { get; set; }
        [DataMember]
        public string NewsDescription { get; set; }
        [DataMember]
        public string NewsType { get; set; }
        [DataMember]
        public bool NewsEditorPick { get; set; }
        [DataMember]
        public DateTime NewsDate { get; set; }
        [DataMember]
        public string NewsAuthor { get; set; }
        [DataMember]
        public string NewsSectionTitle { get; set; }
    }
}
