using System;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class Menu
    {
        [DataMember]
        public int MenuID { get; set; }
        [DataMember]
        public string MenuName { get; set; }
        [DataMember]
        public bool IsActive { get; set; }
    }
}