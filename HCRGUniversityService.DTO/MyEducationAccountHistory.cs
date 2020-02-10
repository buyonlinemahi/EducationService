using System;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class MyEducationAccountHistory
    {
        [DataMember]
        public int MEID { get; set; }
        [DataMember]
        public int UserID { get; set; }
        [DataMember]
        public int EducationID { get; set; }
        [DataMember]
        public DateTime? CompletedDate { get; set; }
        [DataMember]
        public DateTime? PurchaseDate { get; set; }
        [DataMember]
        public string CourseName { get; set; }
        [DataMember]
        public decimal? Price { get; set; }
        [DataMember]
        public int? UserAllAccessPassID { get; set; }
        [DataMember]
        public string TransactionNumber { get; set; }
        [DataMember]
        public string PaymentStatus { get; set; }    
    }
}

