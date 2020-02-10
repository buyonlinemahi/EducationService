using System.Collections.Generic;
using System.Runtime.Serialization;
using HCRGUniversityService.DTO;

namespace HCRGUniversityService.DTO.Paged
{
    [DataContract]
    public class PagedFaculty
    {
        [DataMember]
        public int TotalCount { get; set; }
        [DataMember]
        public IEnumerable<DTO.Faculty> FacultyDetails { get; set; }
    }
}
