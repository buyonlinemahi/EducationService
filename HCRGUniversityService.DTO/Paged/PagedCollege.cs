using System.Collections.Generic;
using System.Runtime.Serialization;
namespace HCRGUniversityService.DTO.Paged
{
  public class PagedCollege
    {
        [DataMember]
        public int TotalCount { get; set; }
        [DataMember]
        public IEnumerable<College> Colleges { get; set; }
    }
}
