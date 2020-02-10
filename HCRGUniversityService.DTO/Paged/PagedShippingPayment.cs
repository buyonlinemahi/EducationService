using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO.Paged
{
    [DataContract]
    public class PagedShippingPayment
    {
        [DataMember]
        public int TotalCount { get; set; }
        [DataMember]
        public IEnumerable<ShippingPayment> ShippingPayments { get; set; }
    }
}
