using HCRGUniversityService.DTO;
using System.Collections.Generic;
using System.ServiceModel;

namespace HCRGUniversityService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICommonService" in both code and config file together.
    [ServiceContract]
    public interface ICommonService
    {
        [OperationContract]
        IEnumerable<State> getAllState();
        [OperationContract]
        string getStateByID(int _id);
        [OperationContract]
        IEnumerable<ShippingMethod> getAllShippingMethod();

        #region Menu
        [OperationContract]
        IEnumerable<Menu> getAllMenu();
        [OperationContract]
        IEnumerable<Menu> GetUserMenuBySpecialMenuID(string SpecialMenuIDs);
        [OperationContract]
        IEnumerable<Menu> GetUserMenuByGroupID(int id);
        #endregion

        #region Suggest Course
        [OperationContract]
        int addSuggestCourse(DTO.SuggestCourse suggestCourse);
        [OperationContract]
        int updateSuggestCourse(DTO.SuggestCourse suggestCourse);
        [OperationContract]
        void deleteSuggestCourse(int id);
        [OperationContract]
        IEnumerable<DTO.SuggestCourse> GetAllSuggestCoursesByOrganizationID(int clientID,int orgID);
        [OperationContract]
        DTO.Paged.PagedSuggestCourse GetAllPagedSuggestCourses(int skip, int take);
        [OperationContract]
        DTO.SuggestCourse getSuggestCourseByID(int id);

        #endregion

        #region Enterprise
        [OperationContract]
        int addEnterprise(DTO.Enterprise enterprise);
        [OperationContract]
        int updateEnterprise(DTO.Enterprise enterprise);
        [OperationContract]
        DTO.Enterprise getEnterpriseByID(int id);
        [OperationContract]
        void deleteEnterpriseByID(int id);
        [OperationContract]
        DTO.Paged.PagedEnterpriseDetail getEnterpriseByEnterpriseClientName(string _searchtext, int _skip, int _take, int OrganizationID);
        [OperationContract]
        IEnumerable<DTO.Enterprise> getEnterpriseAll(int OrganizationID);
        [OperationContract]
        IEnumerable<DTO.Industry> getAllIndustry();
        #endregion


      

        [OperationContract]
        IEnumerable<ClientType> getAllClientType();
    }
}
