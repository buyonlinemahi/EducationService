using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO.Paged
{
  public  class PagedEvaluationQuestion
    {
        [DataMember]
        public int TotalCount { get; set; }
        [DataMember]
        public IEnumerable<EvaluationQuestion> EvaluationQuestions { get; set; }
    }
}
