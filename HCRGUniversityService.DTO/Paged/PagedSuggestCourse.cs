﻿using System.Collections.Generic;
using System.Runtime.Serialization;
using HCRGUniversityService.DTO;

namespace HCRGUniversityService.DTO.Paged
{
    public class PagedSuggestCourse
    {
        [DataMember]
        public int TotalCount { get; set; }
        [DataMember]
        public IEnumerable<DTO.SuggestCourse> SuggestCourseDetails { get; set; }
    }
}
