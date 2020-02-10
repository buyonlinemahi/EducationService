using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO.Paged
{
    [DataContract]
   public class PagedEducationModule
    {
        [DataMember]
        public int TotalCount { get; set; }
        [DataMember]
        public IEnumerable<EducationModule> EducationModules { get; set; }
    }
}
