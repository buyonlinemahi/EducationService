using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO.Paged
{
    [DataContract]
    public class PagedLogSessionDetail
    {
        [DataMember]
        public int TotalCount { get; set; }
        [DataMember]
        public IEnumerable<LogSessionDetail> LogSessionDetails { get; set; }
    }
}
