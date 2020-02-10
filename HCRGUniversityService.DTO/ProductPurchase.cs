using System;
using System.Runtime.Serialization;


namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class ProductPurchase
    {
        [DataMember]
        public int ProductID { get; set; }
        [DataMember]
        public string ProductName { get; set; }
        [DataMember]
        public string ProductDesc { get; set; }
        [DataMember]
        public decimal ProductPrice { get; set; }
        [DataMember]
        public string ProductImage { get; set; }
        [DataMember]
        public string ProductFile { get; set; }
        [DataMember]
        public string ProductType { get; set; }
        [DataMember]
        public DateTime Date { get; set; }

        [DataMember]
        public int? ProductTotalQuantity { get; set; }
        [DataMember]
        public int? ProductCurrentBalance { get; set; }
        [DataMember]
        public string UserFirstname { get; set; }
        [DataMember]
        public string UserLastname { get; set; }
        [DataMember]
        public int UserID { get; set; }
        [DataMember]
        public int ProductShoppingID { get; set; }
        [DataMember]
        public int? ShippingPaymentID { get; set; }
    }
}
