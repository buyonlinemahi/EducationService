using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO.Paged
{
    [DataContract]
  public  class PagedEducationProfession
    {
          [DataMember]
        public int TotalCount { get; set; }
        [DataMember]
          public IEnumerable<EducationProfessionDetail> EducationProfessions { get; set; }
    }
}
