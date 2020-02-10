using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class OrganizationContact : Base.BaseColumn
    {
        [DataMember]
        public int OrganizationContactID { get; set; }
        [DataMember]
        public string OrganizationName { get; set; }
        [DataMember]
        public string Phone { get; set; }
        [DataMember]
        public string Fax { get; set; }
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
        public string OperationHour { get; set; }
        [DataMember]
        public string StartTime { get; set; }
        [DataMember]
        public string EndTime { get; set; }
        [DataMember]
        public string StateName { get; set; }
        
    }
}
