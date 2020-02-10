using System;
using System.Runtime.Serialization;

namespace HCRGUniversityService.DTO
{
    [DataContract]
    public class FileType
    {
        [DataMember]
        public int FileTypeID { get; set; }
        [DataMember]
        public string FileTypeName { get; set; }
    }
}
