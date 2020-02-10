using System;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class UserSubscription
    {
        [DataMember]
        public int UserSubscriptionID { get; set; }
        [DataMember]
        public decimal IndividualAccessPricing { get; set; }
        [DataMember]
        public decimal IndividualAccessPricingStart { get; set; }
        [DataMember]
        public decimal IndividualAccessPricingEnd { get; set; }
        [DataMember]
        public string IndividualAccessTermsOfService { get; set; }
        [DataMember]
        public decimal AllAccessPassPricing { get; set; }
        [DataMember]
        public decimal AllAccessParametersCoursePriceStart { get; set; }
        [DataMember]
        public decimal AllAccessParametersCoursePriceEnd { get; set; }
        [DataMember]
        public bool? AllAccessIncludeProgram { get; set; }
        [DataMember]
        public string AllAccessTermsOfService { get; set; }
        [DataMember]
        public decimal EnterprisePricing { get; set; }
        [DataMember]
        public string EnterpriseTermsOfService { get; set; }
        [DataMember]
        public int OrganizationID { get; set; }
        [DataMember]
        public string OrganizationName { get; set; }
        [DataMember]
        public DateTime CreatedOn { get; set; }
    }
}
