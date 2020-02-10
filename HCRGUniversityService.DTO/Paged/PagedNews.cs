using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO.Paged
{
    [DataContract]
  public  class PagedNews
    {
          [DataMember]
        public int TotalCount { get; set; }
        [DataMember]
          public IEnumerable<News> NewsRecords { get; set; }

    }
}
