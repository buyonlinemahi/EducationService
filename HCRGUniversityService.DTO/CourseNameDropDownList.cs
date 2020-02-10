using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class CourseNameDropDownList
    {
        [DataMember]
        public int EducationID { get; set; }
        [DataMember]
        public string CourseName { get; set; }
    }
}
