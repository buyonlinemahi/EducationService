using System;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class ProductShoppingTemp
    {
        [DataMember]
        public int ProductShoppingTempID { get; set; }
        [DataMember]
        public int UserID { get; set; }
        [DataMember]
        public int ProductID { get; set; }
        [DataMember]
        public int Quantity { get; set; }
        [DataMember]
        public int? CoupanID { get; set; }
        [DataMember]
        public decimal Amount { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public decimal? DiscountAmount { get; set; }
        [DataMember]
        public int? ShippingPaymentID { get; set; }
        [DataMember]
        public bool? IsProcessed { get; set; }
        [DataMember]
        public DateTime? ProcessedDate { get; set; }
        [DataMember]
        public decimal? TaxPercentage { get; set; }
    }
}
    