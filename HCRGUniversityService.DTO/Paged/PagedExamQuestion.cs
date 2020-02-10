using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HCRGUniversityService.DTO.Paged
{
    [DataContract]
  public  class PagedExamQuestion
    {
        [DataMember]
        public int TotalCount { get; set; }
        [DataMember]
        public IEnumerable<ExamQuestion> ExamQuestions { get; set; }
    }
}
