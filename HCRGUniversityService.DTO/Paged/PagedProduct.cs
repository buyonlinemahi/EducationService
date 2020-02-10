using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO.Paged
{
    [DataContract]
   public class PagedProduct
    {

        [DataMember]
        public int TotalCount { get; set; }
        [DataMember]
        public IEnumerable<Product> Products { get; set; }
    }
}
