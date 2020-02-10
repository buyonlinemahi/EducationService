using System.Collections.Generic;
using System.Runtime.Serialization;


namespace HCRGUniversityService.DTO.Paged
{
    [DataContract]
    public class PagedProductPurchase
    {
        [DataMember]
        public int TotalCount { get; set; }
        [DataMember]
        public IEnumerable<ProductPurchase> ProductPurchaseDetails { get; set; }
    }
    
}
