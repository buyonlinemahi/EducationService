using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    public class PagedCourseNameDropDownList
    {
        [DataMember]
        public int TotalCount { get; set; }
        [DataMember]
        public IEnumerable<College> Colleges { get; set; }
    }
}
