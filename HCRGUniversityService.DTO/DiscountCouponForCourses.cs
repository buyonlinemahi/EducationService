using System;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class DiscountCouponForCourses
    {
        [DataMember]
        public int CouponID { get; set; }
        [DataMember]
        public string CouponCode { get; set; }
        [DataMember]
        public string CouponType { get; set; }
        [DataMember]
        public int CouponEducationID { get; set; }
        [DataMember]
        public int CouponProduactID { get; set; }
        [DataMember]
        public decimal CouponDiscount { get; set; }
        [DataMember]
        public DateTime CouponExpiryDate { get; set; }
        [DataMember]
        public DateTime CouponIssueDate { get; set; }
        [DataMember]
        public bool CoupanValid { get; set; }
        [DataMember]
        public string CourseName { get; set; }
    }
}
