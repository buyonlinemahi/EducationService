using System.Collections.Generic;
using System.Runtime.Serialization;
namespace HCRGUniversityService.DTO.Paged
{
   public class PagedExam
   {
       [DataMember]
       public int TotalCount { get; set; }
       [DataMember]
       public IEnumerable<Exam> Exams { get; set; }
    }
}
