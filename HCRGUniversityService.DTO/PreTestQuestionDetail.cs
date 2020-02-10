using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HCRGUniversityService.DTO
{
    [DataContract]
  public class PreTestQuestionDetail
  {
         [DataMember]
        public int EducationID { get; set; }
         [DataMember]
        public int PreTestID { get; set; }
         [DataMember]
        public string PreTestQues { get; set; }
         [DataMember]
        public string PreTestOptionA { get; set; }
         [DataMember]
        public string PreTestOptionB { get; set; }
         [DataMember]
        public string PreTestOptionC { get; set; }
         [DataMember]
        public string PreTestOptionD { get; set; }
         [DataMember]
        public string PreTestAnswer { get; set; }
         [DataMember]
         public int PreTestQuestionID { get; set; }
         [DataMember]
         public string PreTestAnswerType { get; set; }
         [DataMember]
         public bool? PreTestAnswerTrueFalse { get; set; }
    }
}
