using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class Accreditor : Base.BaseColumn
    {
        [DataMember]
        public int AccreditorID { get; set; }
        [DataMember]
        public string AccreditorName { get; set; }
        [DataMember]
        public bool IsActive { get; set; }
        [DataMember]
        public string OrganizationName { get; set; }
    }
}
