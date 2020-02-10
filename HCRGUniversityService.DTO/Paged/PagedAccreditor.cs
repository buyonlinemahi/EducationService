using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO.Paged
{
     [DataContract]
  public class PagedAccreditor
    {
        [DataMember]
        public int TotalCount { get; set; }
        [DataMember]
        public IEnumerable<Accreditor> AccreditorRecords { get; set; }
    }
}
