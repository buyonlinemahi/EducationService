using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class College :Base.BaseColumn
    {
        [DataMember]
        public int CollegeID { get; set; }
        [DataMember]
        public string CollegeName { get; set; }
        [DataMember]
        public bool? IsActive { get; set; }
        [DataMember]
        public string Abbreviation { get; set; }
        [DataMember]
        public string StartNumber { get; set; }
        [DataMember]
        public string OrganizationName { get; set; }

    }
}