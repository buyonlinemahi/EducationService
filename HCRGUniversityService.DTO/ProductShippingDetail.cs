using System;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class ProductShippingDetail
    {
        [DataMember]
        public int ProductShippingDetailID { get; set; }
        [DataMember]
        public DateTime ProductShippedOn { get; set; }
        [DataMember]
        public DateTime CreatedOn { get; set; }
        [DataMember]
        public int CreatedBy { get; set; }
        [DataMember]
        public int? ShippingPaymentID { get; set; }
    }
}
