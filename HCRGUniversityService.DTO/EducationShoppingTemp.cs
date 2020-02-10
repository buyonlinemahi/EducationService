using System;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class EducationShoppingTemp
    {
        [DataMember]
        public int EducationShoppingTempID { get; set; }
        [DataMember]
        public int UserID { get; set; }
        [DataMember]
        public int EducationID { get; set; }
        [DataMember]
        public int EducationTypeID { get; set; }
        [DataMember]
        public int Quantity { get; set; }
        [DataMember]
        public int? CoupanID { get; set; }
        [DataMember]
        public decimal Amount { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public int? CredentialID { get; set; }
        [DataMember]
        public int? ShippingPaymentID { get; set; }
        [DataMember]
        public int? UserAllAccessPassID { get; set; }
        [DataMember]
        public DateTime? ProcessedDate { get; set; }
        [DataMember]
        public decimal? TaxPercentage { get; set; }


    }
}