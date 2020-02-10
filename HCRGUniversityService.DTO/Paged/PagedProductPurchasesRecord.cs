using System.Collections.Generic;
using System.Runtime.Serialization;


namespace HCRGUniversityService.DTO.Paged
{
    public class PagedProductPurchasesRecord
    {
        [DataMember]
        public int TotalCount { get; set; }
        [DataMember]
        public IEnumerable<ProductPurchase> ProductPurchasesRecords { get; set; }
    }
}
