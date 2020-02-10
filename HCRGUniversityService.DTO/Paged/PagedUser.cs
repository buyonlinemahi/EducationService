using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO.Paged
{
   [DataContract]
    public class PagedUser
    {
        [DataMember]
        public int TotalCount { get; set; }
        [DataMember]
        public IEnumerable<User> Users { get; set; }
    }
}
