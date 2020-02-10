using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class BillingAddress
    {
        [DataMember]
        public int BillingAddressID { get; set; }
        [DataMember]
        public int BAUserID { get; set; }
        [DataMember]
        public string BAFirstName { get; set; }
        [DataMember]
        public string BALastName { get; set; }
        [DataMember]
        public string BAAddress { get; set; }
        [DataMember]
        public string BAAddress2 { get; set; }
        [DataMember]
        public string BACity { get; set; }
        [DataMember]
        public int BAStateID { get; set; }
        [DataMember]
        public string BAPostalCode { get; set; }
        [DataMember]
        public string BAPhone { get; set; }
    }
}
