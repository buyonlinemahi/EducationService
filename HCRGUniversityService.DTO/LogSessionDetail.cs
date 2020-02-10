using System;
using System.Runtime.Serialization;
namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class LogSessionDetail
    {
        [DataMember]
        public int LogSessionID { get; set; }
        [DataMember]
        public int SessionId { get; set; }
        [DataMember]
        public int UserId { get; set; }
        [DataMember]
        public string PageUrl { get; set; }
        [DataMember]
        public string Browser { get; set; }
        [DataMember]
        public int MEID { get; set; }
        [DataMember]
        public DateTime LogCreatedDate { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string EmailID { get; set; }
        [DataMember]
        public string CourseName { get; set; }
    }
}
