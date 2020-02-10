using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class PlanPackages
    {
        [DataMember]
        public int PlanID { get; set; }
        [DataMember]
        public int ClientID { get; set; }
        [DataMember]
        public string PlanName { get; set; }
        [DataMember]
        public int UserID { get; set; }
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public int UserPlanID { get; set; }
        [DataMember]
        public int CoursePlanID { get; set; }
        [DataMember]
        public string CourseName { get; set; }
        [DataMember]
        public int EducationID { get; set; }
        [DataMember]
        public bool IsPlanApplied { get; set; }
    }
}
