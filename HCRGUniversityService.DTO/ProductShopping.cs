using System;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class ProductShopping
    {
        [DataMember]
        public int ProductShoppingID { get; set; }
        [DataMember]
        public int UserID { get; set; }
        [DataMember]
        public int ProductID { get; set; }
        [DataMember]
        public int Quantity { get; set; }
        [DataMember]
        public int? CoupanID { get; set; }
        [DataMember]
        public decimal Grandtotal { get; set; }
        [DataMember]
        public int OrderID { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
         
        [DataMember]
        public int? ShippingPaymentID { get; set; }

        [DataMember]
        public decimal? TaxPercentage { get; set; }
    }
}
