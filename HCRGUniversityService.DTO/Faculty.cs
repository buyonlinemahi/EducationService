using System;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class Faculty
    {
        [DataMember]
        public int FacultyID { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Company { get; set; }
        [DataMember]
        public string Phone { get; set; }
        [DataMember]
        public string ProfessionalTitle { get; set; }
        [DataMember]
        public string AddressStreet { get; set; }
        [DataMember]
        public string AddressFloor { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string State { get; set; }
        [DataMember]
        public string Zip { get; set; }
        [DataMember]
        public string AreaOfExpertise { get; set; }
        [DataMember]
        public string Topics { get; set; }
        [DataMember]
        public string Resume { get; set; }
        [DataMember]
        public DateTime? CreatedDate { get; set; }
        [DataMember]
        public int OrganizationID { get; set; }
        [DataMember]
        public string OrganizationName { get; set; }
    }
}
