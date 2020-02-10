using System;
using System.Runtime.Serialization;
namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class LogSession
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
    }
}
