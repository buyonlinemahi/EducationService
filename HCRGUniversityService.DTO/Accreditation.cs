using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class Accreditation : Base.BaseColumn
    {
        [DataMember]
        public int AccreditationID { get; set; }
        [DataMember]
        public string AccreditationContent { get; set; }
        [DataMember]
        public string OrganizationName { get; set; }
    }
}
