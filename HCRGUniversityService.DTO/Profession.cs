using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class Profession  :Base.BaseColumn
    {
        [DataMember]
        public int ProfessionID { get; set; }
        [DataMember]
        public string ProfessionTitle { get; set; }
        [DataMember]
        public bool IsActive { get; set; }
        [DataMember]
        public string OrganizationName { get; set; }
    }
}