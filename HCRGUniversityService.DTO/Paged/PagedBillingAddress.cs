using System.Collections.Generic;
using System.Runtime.Serialization;
    

namespace HCRGUniversityService.DTO.Paged
{
     [DataContract]
    public class PagedBillingAddress
    {
        [DataMember]
        public int TotalCount { get; set; }
        [DataMember]
        public IEnumerable<BillingAddress> BillingAddresses { get; set; }
    }
}
