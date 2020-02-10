using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class CollegeEducationSearch
    {
        [DataMember]
        public int CollegeID { get; set; }
        [DataMember]
        public string CollegeName { get; set; }
        [DataMember]
        public int? CollegeCourseID { get; set; }
        [DataMember]
        public bool IsActive { get; set; }
    }
}