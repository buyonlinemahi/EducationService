using System;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class User : Base.BaseColumn
    {
        [DataMember]
        public int UID { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string EmailID { get; set; }
        [DataMember]
        public string Company { get; set; }
        [DataMember]
        public string Phone { get; set; }
        [DataMember]
        public string ProfessionalTitle { get; set; }
        [DataMember]
        public bool IsActive { get; set; }
        [DataMember]
        public bool IsLocked { get; set; }
        [DataMember]
        public int FailedAttemptCount { get; set; }
        [DataMember]
        public DateTime? LastLoginDate { get; set; }
        [DataMember]
        public string Role { get; set; }
        [DataMember]
        public bool? IsAllAccessPricing { get; set; }
        [DataMember]
        public int? AAPCouponID { get; set; }
        [DataMember]
        public int? UserAllAccessPassID { get; set; }
        [DataMember]
        public bool? IsManagement { get; set; }
        [DataMember]
        public bool? IsCoursePreview { get; set; }
        [DataMember]
        public bool? IsVerified { get; set; }
        [DataMember]
        public DateTime? VerifiedOn { get; set; }
        [DataMember]
        public bool? IsCleared { get; set; }
        [DataMember]
        public DateTime? ClearedOn { get; set; }
        [DataMember]
        public int? ClearedBy { get; set; }
        [DataMember]
        public int UserMenuGroupID { get; set; }
        [DataMember]
        public string SpecialMenuIDs { get; set; }
        [DataMember]
        public string UserSessionID { get; set; }
        
    }
}
