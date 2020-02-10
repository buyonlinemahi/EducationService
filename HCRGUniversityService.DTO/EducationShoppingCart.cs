using System;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class EducationShoppingCart
    {
        [DataMember]
        public int TempID { get; set; }
        [DataMember]
        public int EduorProID { get; set; }
        [DataMember]
        public int UserID { get; set; }
        [DataMember]
        public int Quantity { get; set; }
        [DataMember]
        public int? CoupanID { get; set; }
        [DataMember]
        public decimal Amount { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public string PName { get; set; }
        [DataMember]
        public string CartType { get; set; }
        [DataMember]
        public string PType { get; set; }
        [DataMember]
        public decimal Price { get; set; }
        [DataMember]
        public int? CredentialID { get; set; }
        [DataMember]
        public int EducationTypeID { get; set; }
        [DataMember]
        public decimal? DiscountAmount { get; set; }
        [DataMember]
        public int? ShippingPaymentID { get; set; }
        [DataMember]
        public int? UserAllAccessPassID { get; set; }
        [DataMember]
        public decimal? TaxPercentage { get; set; }
    }
}