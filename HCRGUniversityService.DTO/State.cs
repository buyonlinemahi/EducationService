using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class State
    {
        [DataMember]
        public int StateID { get; set; }
        [DataMember]
        public string StateName { get; set; }
    }
}
