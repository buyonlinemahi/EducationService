using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO.Paged
{
    [DataContract]
    public class PagedMyEducationAccountHistory
    {
        [DataMember]
        public int TotalCount { get; set; }
        [DataMember]
        public IEnumerable<MyEducationAccountHistory> accountHistory { get; set; }
    }
}
