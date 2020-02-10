using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class ShippingMethod
    {
        [DataMember]
        public int ShippingMethodID { get; set; }
        [DataMember]
        public string ShippingMethodName { get; set; }
        [DataMember]
        public decimal ShippingMethodAmount { get; set; }
    }
}
