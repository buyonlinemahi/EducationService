using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO.Paged
{
    [DataContract]
    public class PagedMyEducation
    {
        [DataMember]
        public int TotalCount { get; set; }
        [DataMember]
        public IEnumerable<MyEducationDetail> myeducation { get; set; }
    }
}
