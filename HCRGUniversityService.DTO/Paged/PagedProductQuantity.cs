using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO.Paged
{
    [DataContract]
    public class PagedProductQuantity
    {
        [DataMember]
        public int TotalCount { get; set; }
        [DataMember]
        public IEnumerable<ProductQuantity> ProductQuantityDetails { get; set; }
    }
}
