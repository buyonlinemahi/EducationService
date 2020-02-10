using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class Product
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
        public int? ProductTotalQuantity { get; set; }
        [DataMember]
        public int? ProductCurrentBalance { get; set; } 

    }
}
