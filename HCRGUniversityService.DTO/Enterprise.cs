using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class Enterprise : Base.BaseColumn
    {
        [DataMember]
        public int EnterpriseID { get; set; }
        [DataMember]
        public string EnterpriseClientName { get; set; }
        [DataMember]
        public string EnterpriseAddress { get; set; }
        [DataMember]
        public string EnterpriseCity { get; set; }
        [DataMember]
        public int EnterpriseStateID { get; set; }
        [DataMember]
        public string EnterpriseZip { get; set; }
        [DataMember]
        public string EnterprisePhone { get; set; }
        [DataMember]
        public string EnterpriseEmail { get; set; }
        [DataMember]
        public decimal? EnterpriseCourseStartPrice { get; set; }
        [DataMember]
        public decimal? EnterpriseCourseEndPrice { get; set; }
        [DataMember]
        public bool? EnterpriseProgram { get; set; }
        [DataMember]
        public DateTime? EnterpriseEndDate { get; set; }
        [DataMember]
        public int EnterpriseNumberUser { get; set; }
        [DataMember]
        public int? CreatedBy { get; set; }
        [DataMember]
        public DateTime? CreatedOn { get; set; }
    }
}
