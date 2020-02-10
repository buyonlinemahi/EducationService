using System.Collections.Generic;
using System.Runtime.Serialization;

   namespace HCRGUniversityService.DTO.Paged
    {
        public class PagedClient
        {
            [DataMember]
            public IEnumerable<Client> Clients { get; set; }
            [DataMember]
            public int TotalCount { get; set; }
        }
    }

