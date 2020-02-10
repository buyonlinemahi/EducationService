using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO.Paged
{
    [DataContract]
    public class PagedUserCardDetail
    {
        [DataMember]
        public int TotalCount { get; set; }
        [DataMember]
        public IEnumerable<UserCardDetail> UserCardDetails { get; set; }
    }
}