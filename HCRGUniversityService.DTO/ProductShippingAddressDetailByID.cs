using System;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
     [DataContract]
    public class ProductShippingAddressDetailByID
    {
         [DataMember]
        public string SAFirstName { get; set; }
         [DataMember]
        public string SALastName { get; set; }
         [DataMember]
        public string SAAddress { get; set; }
         [DataMember]
        public string SAAddress2 { get; set; }
         [DataMember]
        public string SACity { get; set; }
         [DataMember]
        public string StateName { get; set; }
         [DataMember]
        public int ProductShoppingID { get; set; }
         [DataMember]
         public string SAPostalCode { get; set; }
         [DataMember]
         public int SAStateID { get; set; }
    }
}
