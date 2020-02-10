using System.ServiceModel;
using HCRGUniversityService.DTO;
using System.Collections.Generic;
using HCRGUniversityService.DTO.Paged;

namespace HCRGUniversityService.Contracts
{
    [ServiceContract]
    public interface IAboutUsService
    {
        [OperationContract]
        int AddAboutUs(AboutUs aboutus);

        [OperationContract]
        int UpdateAboutUs(AboutUs aboutus);

        [OperationContract]
        void DeleteAboutUs(int aboutUsID);

        [OperationContract]
        IEnumerable<AboutUs> getAllRecords(int OrganizationID);

        [OperationContract]
        PagedAboutUs GetAllPagedAboutus(int skip, int take, int OrganizationID);

        [OperationContract]
        IEnumerable<AboutUs> GetAllAboutUsByOrganizationID(int OrganizationID, int ClientID);
    }
}