using System.Collections.Generic;
using System.Runtime.Serialization;
    

namespace HCRGUniversityService.DTO.Paged
{
    [DataContract]
    public class PagedShippingAddress
    {
        [DataMember]
        public int TotalCount { get; set; }
        [DataMember]
        public IEnumerable<ShippingAddress> ShippingAddresses { get; set; }
    }
}
