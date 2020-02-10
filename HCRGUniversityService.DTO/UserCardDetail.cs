using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class UserCardDetail
    {
        [DataMember]
        public int UserCardDetailID { get; set; }
        [DataMember]
        public int UserID { get; set; }
        [DataMember]
        public string UserCardName { get; set; }
        [DataMember]
        public string UserCardNumber { get; set; }
        [DataMember]
        public string UserCardExpiry { get; set; }
        [DataMember]
        public int? CreatedBy { get; set; }
        [DataMember] 
        public DateTime? CreatedOn { get; set; }
        [DataMember]
        public int? UpdatedBy { get; set; }
        [DataMember]
        public DateTime? UpdatedOn { get; set; }
        [DataMember]
        public int? DeletedBy { get; set; }
        [DataMember]
        public DateTime? DeletedOn { get; set; }
    }
}
