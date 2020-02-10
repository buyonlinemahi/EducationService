using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO.Paged
{
    [DataContract]
    public class PagedEducationFormat
    {
        [DataMember]
        public int TotalCount { get; set; }
        [DataMember]
        public IEnumerable<EducationFormat> EducationFormats { get; set; }
    }
}
