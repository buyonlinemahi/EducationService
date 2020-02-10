using System.ServiceModel;
using HCRGUniversityService.DTO;
using System.Collections.Generic;
using HCRGUniversityService.DTO.Paged;

namespace HCRGUniversityService.Contracts
{
    [ServiceContract]
    public interface ICertificationTitleOptionService
    {
        [OperationContract]
        int AddCertificationTitleOption(DTO.CertificationTitleOption _certificationTitleOption);
        [OperationContract]
        int UpdateCertificationTitleOption(DTO.CertificationTitleOption _certificationTitleOption);
        [OperationContract]
        void DeleteCertificationTitleOption(int id);
        [OperationContract]
        IEnumerable<CertificationTitleOption> GetAllCertificationTitleOptions();
        [OperationContract]
        IEnumerable<CourseNameDropDownList> GetCourseDropDownList(int OrganizationID);
        [OperationContract]
        CertificationTitleOption GetCertificationTitleOptionsByID(int CertificationTitleOptionID);
        [OperationContract]
        CertificationTitleOption GetCertificationTitleOptionsByEducationID(int CertificationTitleOptionID);
        [OperationContract]
        DTO.Paged.PagedCertificationTitleOption GetAllPagedCertificationTitleOption(int skip, int take);
    }
}
