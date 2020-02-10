using System;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class UserAllAccessPass
    {
        [DataMember]
        public int UserAllAccessPassID { get; set; }
        [DataMember]
        public int UserID { get; set; }
        [DataMember]
        public int? AAPCouponID { get; set; }
        [DataMember]
        public bool? IsAllAccessPricingAmountRecevied { get; set; }
        [DataMember]
        public DateTime? AllAccessStartDate { get; set; }
        [DataMember]
        public DateTime? AllAccessEndDate { get; set; }
        [DataMember]
        public int? ShippingPaymentID { get; set; }
        [DataMember]
        public int? UserSubscriptionID { get; set; }
        
    }
}
