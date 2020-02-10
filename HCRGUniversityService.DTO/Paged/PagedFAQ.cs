using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO.Paged
{
    [DataContract]
  public  class PagedFAQ
    {
          [DataMember]
        public int TotalCount { get; set; }
        [DataMember]
          public IEnumerable<FAQ> FAQDetails { get; set; }
    }
}
