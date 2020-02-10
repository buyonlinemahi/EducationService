using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO.Paged
{
    [DataContract]
    public class PagedEducationNewsSearch
    {
        [DataMember]
        public int TotalCount { get; set; }
        [DataMember]
        public IEnumerable<EducationNewsSearch> educationNewsSearch { get; set; }
    }
}
