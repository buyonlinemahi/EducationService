using System;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO.Base
{
    [DataContract]
    public class BaseDataColumn
    {
        [DataMember]
        public DateTime? ApproveOn { get; set; }
        [DataMember]
        public int? ApproveBy { get; set; }
    }
}
