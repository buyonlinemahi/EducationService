using System;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class Organization
    {
        [DataMember]
        public int OrganizationID { get; set; }
        [DataMember]
        public string OrganizationName { get; set; }
        [DataMember]
        public string WebsiteName { get; set; }
        [DataMember]
        public int? ThemeID { get; set; }
        [DataMember]
        public string LogoImage { get; set; }
        [DataMember]
        public bool? IsCertificate { get; set; }
        [DataMember]
        public bool? IsWebPortal { get; set; }
        [DataMember]
        public string RegisteredPaypalEmailID { get; set; }
        [DataMember]
        public string FaviconImage { get; set; }
        [DataMember]
        public string MenuIDs { get; set; }
    }
}
