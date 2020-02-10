using System.Runtime.Serialization;


namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class ShippingPayment
    {
        [DataMember]
        public int ShippingPaymentID { get; set; }
        [DataMember]
        public int UserID { get; set; }
        [DataMember]
        public int BillingAddressID { get; set; }
        [DataMember]
        public int ShippingAddressID { get; set; }
        [DataMember]
        public int ShippingMethodID { get; set; }
        [DataMember]
        public int? CreatedBy { get; set; }
        [DataMember]
        public System.DateTime? CreatedOn { get; set; }
        [DataMember]
        public bool? IsPaymentRecevied { get; set; }
        [DataMember]
        public string TransactionNumber { get; set; }
        [DataMember]
        public System.DateTime? TransactionDatetime { get; set; }
        [DataMember]
       public string PaymentStatus { get; set; } 
    }
}
