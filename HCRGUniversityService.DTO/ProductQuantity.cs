using System;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class ProductQuantity
    {
        [DataMember]
        public int ProductQuantityID { get; set; }
        [DataMember]
        public int ProductID { get; set; }
        [DataMember]
        public int ProdQuantity { get; set; }
        [DataMember]
        public DateTime ProdQuantityDate { get; set; }
        [DataMember]
        public int UserID { get; set; }
        [DataMember]
        public string Mode { get; set; }
    }
}
