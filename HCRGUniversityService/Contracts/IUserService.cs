using System.ServiceModel;
using HCRGUniversityService.DTO;
using System.Collections.Generic;
using HCRGUniversityService.DTO.Paged;

namespace HCRGUniversityService.Contracts
{
    [ServiceContract]
    public interface IUserService
    {
        #region user
        [OperationContract]
        User GetUserByID(int userID);

        [OperationContract]
        int AddUser(User user);

        [OperationContract]
        int UpdateUser(User user);

        [OperationContract]
        void UpdateUserPassword(int uid, string pwd);

        [OperationContract]
        User GetUserByUserName(string userName);

        [OperationContract]
        IEnumerable<User> GetUsersAll(int OrganizationID);

        [OperationContract]
        PagedUser GetUsersByName(string name, int skip, int take, int clientID);

        [OperationContract]
        DTO.User GetUserByEmailAndOrganizationId(string userEmailID, int OrganizationID);

        [OperationContract]
        int ResetUserFailedAttemptCount(User user);

        [OperationContract]
        int UpdateUserFailedAttemptCount(User user);

        [OperationContract]
        PagedUser GetAllPagedUser(int skip, int take, int clientID);

        //user reset temp password...hp
        [OperationContract]
        int AddUserResetTempPassword(int uid, string tempPwd);

        [OperationContract]
        void DeleteUserResetTempPassword(int uid, string tempPwd);

        [OperationContract]
        bool matchUserResetTempPassword(int uid, string tempPwd);

        [OperationContract]
        int updateUserVerification(int UserID, bool? _isVerified);

        [OperationContract]
        int clearedUserDetail(int UserID, bool? _isCleared);

        [OperationContract]
        DTO.Paged.PagedUser getUserVerifiedDetails(int _skip, int _take, int OrganizationID);

        [OperationContract]
        IEnumerable<DTO.User> GetUsersByPlanID(int planID);

        [OperationContract]
        int GetDefaulClientAdminByOrganizationID(int _orgID);

        [OperationContract]
        IEnumerable<DTO.UserMenuGroupAndPermission> GetAllUserMenuGroupAndPremissionAccordingToOrganizationID(int OrganizationID);

        [OperationContract]
        IEnumerable<DTO.ClientAndUserbySearchCriterias> GetClientAndUserbySearchCriterias(int OrganizationID, int ClientTypeID, string SelectionTypeName, int SelectionClientTypeID, string SearchText);

        [OperationContract]
        void UpdateUserSessionIDByUserID(int userId, string userSessionID);
        
        [OperationContract]
        void ResetUserSessionID(int UserID);
        #endregion

        #region userCardDetail

        [OperationContract]
        int addUserCardDetail(UserCardDetail _userCardDetail);

        [OperationContract]
        int updateUserCardDetail(UserCardDetail _userCardDetail);

        [OperationContract]
        UserCardDetail getUserCardDetailByID(int id);

        [OperationContract]
        PagedUserCardDetail getUserCardDetailByUserID(int userID, int skip, int take);

        #endregion

        #region User Subscription
        [OperationContract]
        int AddUserSubscription(DTO.UserSubscription userSubscription);
        [OperationContract]
        int UpdateUserSubscription(DTO.UserSubscription userSubscription);
        [OperationContract]
        DTO.UserSubscription GetUserSubscriptionDetails();
        [OperationContract]
        IEnumerable<UserSubscription> GetAllUserSubscriptionByOrganizationID(int OrganizationID, int ClientID);
        [OperationContract]
        DTO.UserSubscription GetUserSubscriptionByID(int userSubscriptionID);

        #endregion

        #region EnterprisePackageRegister

        [OperationContract]
        int addEnterprisePackageRegister(DTO.EnterprisePackageRegister _EnterprisePackageRegister);
        [OperationContract]
        int updateEnterprisePackageRegister(DTO.EnterprisePackageRegister _EnterprisePackageRegister);
        [OperationContract]
        void deleteEnterprisePackageRegister(int id);
        [OperationContract]
        DTO.EnterprisePackageRegister getEnterprisePackageRegisterByID(int id);
        //[OperationContract]
        //DTO.EnterprisePackageRegister getEnterprisePackageRegisterByUserID(int userID);
        [OperationContract]
        DTO.Paged.PagedEnterprisePackageRegister GetAllPagedEnterprisePackageRegister(int skip, int take, int OrganizationID);

        [OperationContract]
        IEnumerable<EnterprisePackageRegister> GetAllEnterprisePackageRegistersByOrganizationID(int OrganizationID);
        #endregion

        #region User All Access Pass
        [OperationContract]
        int addUserAllAccessPass(DTO.UserAllAccessPass userSubscription);
        [OperationContract]
        int updateUserAllAccessPass(DTO.UserAllAccessPass userSubscription);
        [OperationContract]
        DTO.UserAllAccessPass getUserAllAccessPassByID(int ID);
        [OperationContract]
        DTO.UserAllAccessPass getUserAllAccessPassByUserID(int UserID);
        [OperationContract]
        int checkUserAllAccessPassByUserID(int userAllAccessPassID);
        #endregion

        #region User Menu Group
        [OperationContract]
        DTO.Paged.PagedUserMenuGroup GetUserMenuGroup(int OrganizationID);
        [OperationContract]
        IEnumerable<DTO.UserMenuGroup> GetAllUserMenuGroupByOrganizationID(int OrganizationID);
        [OperationContract]
        int AddUserMenuGroup(DTO.UserMenuGroup _userMenuGroup);
        [OperationContract]
        int UpdateUserMenuGroup(DTO.UserMenuGroup _userMenuGroup);
        [OperationContract]
        DTO.UserMenuGroup GetUserMenuGroupByID(int _userMenuGroupID);
        
        #endregion

        #region User Menu Permission
        [OperationContract]
        int AddUserMenuPermission(DTO.UserMenuPermission _userMenuPermission);
        [OperationContract]
        int UpdateUserMenuPermission(DTO.UserMenuPermission _userMenuPermission);
        [OperationContract]
        DTO.UserMenuPermission GetUserMenuPermissionByID(int _userMenuPermissionID);
        [OperationContract]
        DTO.UserMenuPermission GetUserMenuPermissionByUserMenuGroupID(int _userMenuGroupID);
        [OperationContract]
        DTO. UserMenuGroup GetUserMenuGroupByMenuIDs(string MenuIDs, int OrganizationID);
        [OperationContract]
        DTO.UserMenuGroup GetUserMenuGroupByGroupName(string GroupName, int OrganizationID);
        #endregion



    }
}