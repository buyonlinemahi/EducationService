using System;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class UserMenuPermission
    {
        [DataMember]
        public int UserMenuPermissionID { get; set; }
        [DataMember]
        public int UserMenuGroupID { get; set; }
        [DataMember]
        public string MenuIDs { get; set; }
    }
}
