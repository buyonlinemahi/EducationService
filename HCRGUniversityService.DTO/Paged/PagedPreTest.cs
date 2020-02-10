
using System.Collections.Generic;
using System.Runtime.Serialization;
namespace HCRGUniversityService.DTO.Paged
{
  public class PagedPreTest
    {
        [DataMember]
        public int TotalCount { get; set; }
        [DataMember]
        public IEnumerable<PreTest> PreTests { get; set; }
    }
}
