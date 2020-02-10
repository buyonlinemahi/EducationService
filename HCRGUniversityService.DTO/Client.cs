using System;
using System.Runtime.Serialization;


namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class Client : Base.BaseDataColumn
    {
        [DataMember]
        public int ClientID { get; set; }
        [DataMember]
        public int ClientTypeID { get; set; }
        [DataMember]
        public string OrganizationID { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string EmailID { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string Address2 { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public int StateID { get; set; }
        [DataMember]
        public string Zip { get; set; }
        [DataMember]
        public string Phone { get; set; }
        [DataMember]
        public bool? IsApproved { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public bool? IsActive { get; set; }
        [DataMember]
        public bool? IsEmailSent { get; set; }
        [DataMember]
        public string ClientSessionID { get; set; }
    }
}
