using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO.Paged
{
  public class PagedNewsDetail
    {
          [DataMember]
        public int TotalCount { get; set; }
        [DataMember]
          public IEnumerable<NewsFullDetail> NewsFullDetailRecords { get; set; }

    }
}
