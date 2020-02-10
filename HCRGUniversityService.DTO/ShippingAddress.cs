using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class ShippingAddress
    {
        [DataMember]
        public int ShippingAddressID { get; set; }
        [DataMember]
        public int SAUserID { get; set; }
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
        public int SAStateID { get; set; }
        [DataMember]
        public string SAPostalCode { get; set; }
        [DataMember]
        public string SAPhone { get; set; }
        [DataMember]
        public bool? SABillingAddressSame { get; set; }
    }
}
