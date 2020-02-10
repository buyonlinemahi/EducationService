using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO.Paged
{
    [DataContract]
    public class PagedEducation
    {
        [DataMember]
        public IEnumerable<EducationSearchResult> Educations { get; set; }
        [DataMember]
        public IEnumerable<EducationDetail> educationsDetail { get; set; }
        [DataMember]
        public IEnumerable<Education> _educations { get; set; }
        [DataMember]
        public int TotalCount { get; set; }
    }
}
