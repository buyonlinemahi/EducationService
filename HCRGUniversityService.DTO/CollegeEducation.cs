using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class CollegeEducation
    {
        [DataMember]
        public int CollegeCourseID { get; set; }
        [DataMember]
        public int CollegeID { get; set; }
        [DataMember]
        public int EducationID { get; set; }
        [DataMember]
        public bool IsActive { get; set; }
    }
}