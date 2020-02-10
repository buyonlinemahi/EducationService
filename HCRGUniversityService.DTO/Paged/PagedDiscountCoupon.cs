using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO.Paged
{
    [DataContract]
   public class PagedDiscountCoupon
    {      
        [DataMember]
        public int TotalCount { get; set; }
        [DataMember]
        public IEnumerable<DiscountCoupon> DiscountCoupans { get; set; }
        [DataMember]
        public IEnumerable<DiscountCouponForCourses> DiscountCoupansForCourse { get; set; }
    }
}
