using System.ServiceModel;
using HCRGUniversityService.DTO;
using System.Collections.Generic;
using HCRGUniversityService.DTO.Paged;
namespace HCRGUniversityService.Contracts
{
    [ServiceContract]
    public interface ICollegeService
    {
        [OperationContract]
        int AddCollege(College college);

        [OperationContract]
        int UpdateCollege(College college);

        [OperationContract]
        void DeleteCollege(int collegeID, bool IsActive);

        [OperationContract]
        College GetCollegeByID(int collegeID);

        [OperationContract]
        IEnumerable<College> GetAllCollegeWeb(int OrganizationID);

        [OperationContract]
        IEnumerable<College> GetAllCollegeActiveWeb(int OrganizationID);

        [OperationContract]
        IEnumerable<College> getAllCollege(int clientID);

        [OperationContract]
        IEnumerable<College> getAllCollegeActive(int clientID);

        [OperationContract]
        PagedCollege GetAllPagedCollege(int skip, int take, int clientID);

        //faculty..hp
        [OperationContract]
        int AddFaculty(Faculty _faculty);

        [OperationContract]
        int UpdateFaculty(Faculty _faculty);


        [OperationContract]
        DTO.Paged.PagedFaculty GetAllPagedFaculty(int skip, int take, int organizationID, int ClientID);

        [OperationContract]
        DTO.Faculty GetFacultyById(int id);

        [OperationContract]
        IEnumerable<College> GetAllCollegeByOrganizationID(int _organizationID);
    }

}