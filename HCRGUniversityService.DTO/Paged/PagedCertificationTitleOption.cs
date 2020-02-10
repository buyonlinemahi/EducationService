using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO.Paged
{
    [DataContract]
    public class PagedCertificationTitleOption
    {
        [DataMember]
        public int TotalCount { get; set; }
        [DataMember]
        public IEnumerable<CertificationTitleOption> CertificationTitleOptionDetails { get; set; }

    }
}
