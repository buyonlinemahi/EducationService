using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO.Paged
{
    public class PagedUserMenuGroup
    {
        [DataMember]
        public int TotalCount { get; set; }
        [DataMember]
        public IEnumerable<UserMenuGroup> UserMenuGroupDetails { get; set; }
    }
}
