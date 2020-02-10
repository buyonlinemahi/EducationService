using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO.Paged
{
    [DataContract]
    public class PagedEvents
    {
        [DataMember]
        public IEnumerable<Event> _events { get; set; }
        [DataMember]
        public int TotalCount { get; set; }
    }
}
