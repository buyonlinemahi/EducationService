using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO.Paged
{
    [DataContract]
    public class PagedAboutUs
    {
        [DataMember]
        public int TotalCount { get; set; }
        [DataMember]
        public IEnumerable<AboutUs> AboutUsRecords { get; set; }
    }
}
