using System.ServiceModel;
using AutoMapper;
using HCRGUniversity.Core.BL;
using HCRGUniversityService.Contracts;
using HCRGUniversityService.CustomServiceBehaviors;
using System.Collections.Generic;
using HCRGUniversityService.DTO;

namespace HCRGUniversityService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    [AutoMapperServiceBehavior]
    public class UserService : IUserService
    {
        private readonly IUser _user;
        private readonly IUserCardDetail _userCardDetail;
        private readonly IUserSubscription _userSubscription;
        private readonly IEnterprisePackageRegister _EnterprisePackageRegister;
        private readonly IUserAllAccessPass _userAllAccessPass;

        public UserService(IUser user, IUserCardDetail userCardDetail, IUserSubscription userSubscription, IEnterprisePackageRegister EnterprisePackageRegister, IUserAllAccessPass userAllAccessPass)
        {
            _user = user;
            _userCardDetail = userCardDetail;
            _userSubscription = userSubscription;
            _EnterprisePackageRegister = EnterprisePackageRegister;
            _userAllAccessPass = userAllAccessPass;
        }
        #region Users
        public DTO.User GetUserByID(int userID)
        {
            return Mapper.Map<DTO.User>(_user.GetUserByID(userID));
        }

        public int AddUser(DTO.User user)
        {
            return _user.AddUser(Mapper.Map<DTO.User, HCRGUniversity.Core.BL.Model.User>(user));
        }

        public int UpdateUser(DTO.User user)
        {
            return _user.UpdateUser(Mapper.Map<DTO.User, HCRGUniversity.Core.BL.Model.User>(user));
        }

        public void UpdateUserPassword(int uid, string pwd)
        {
            _user.UpdateUserPassword(uid, pwd);
        }

        public DTO.User GetUserByUserName(string userName)
        {
            return Mapper.Map<DTO.User>(_user.GetUserByUserName(userName));
        }

        public DTO.User GetUserByEmailAndOrganizationId(string userEmailID, int OrganizationID)
        {
            return Mapper.Map<DTO.User>(_user.GetUserByEmailAndOrganizationId(userEmailID, OrganizationID));
        }

        public IEnumerable<DTO.User> GetUsersAll(int OrganizationID)
        {
            return Mapper.Map<IEnumerable<DTO.User>>(_user.GetUsersAll(OrganizationID));
        }

        public DTO.Paged.PagedUser GetUsersByName(string name, int skip, int take, int clientID)
        {
            return Mapper.Map<DTO.Paged.PagedUser>(_user.GetUsersByName(name, skip, take, clientID));
        }

        public int ResetUserFailedAttemptCount(DTO.User user)
        {
            return _user.ResetUserFailedAttemptCount(Mapper.Map<DTO.User, HCRGUniversity.Core.BL.Model.User>(user));
        }

        public int UpdateUserFailedAttemptCount(DTO.User user)
        {
            return _user.UpdateUserFailedAttemptCount(Mapper.Map<DTO.User, HCRGUniversity.Core.BL.Model.User>(user));
        }

        //LAzy Binding
        public DTO.Paged.PagedUser GetAllPagedUser(int skip, int take, int clientID)
        {
            return Mapper.Map<DTO.Paged.PagedUser>(_user.GetAllPagedUser(skip, take, clientID));
        }

        //user reset temp password...hp
        public int AddUserResetTempPassword(int uid, string tempPwd)
        {
            return _user.AddUserResetTempPassword(uid, tempPwd);
        }

        public void DeleteUserResetTempPassword(int uid, string tempPwd)
        {
            _user.DeleteUserResetTempPassword(uid, tempPwd);
        }

        public bool matchUserResetTempPassword(int uid, string tempPwd)
        {
            return _user.matchUserResetTempPassword(uid, tempPwd);
        }

        public int updateUserVerification(int UserID, bool? _isVerified)
        {
            return _user.UpdateUserVerification(UserID, _isVerified);
        }

        public int clearedUserDetail(int UserID, bool? _isCleared)
        {
            return _user.ClearedUserDetail(UserID, _isCleared);
        }

        public DTO.Paged.PagedUser getUserVerifiedDetails(int _skip, int _take, int OrganizationID)
        {
            return Mapper.Map<DTO.Paged.PagedUser>(_user.GetUserVerifiedDetails(_skip, _take, OrganizationID));
        }

        public IEnumerable<DTO.User> GetUsersByPlanID(int planID)
        {
            return Mapper.Map<IEnumerable<DTO.User>>(_user.GetUsersByPlanID(planID));
        }

        public int GetDefaulClientAdminByOrganizationID(int _orgID)
        {
            return _user.GetDefaulClientAdminByOrganizationID(_orgID);
        }

        public IEnumerable<DTO.UserMenuGroupAndPermission> GetAllUserMenuGroupAndPremissionAccordingToOrganizationID(int OrganizationID)
        {
            return Mapper.Map<IEnumerable<DTO.UserMenuGroupAndPermission>>(_user.GetAllUserMenuGroupAndPremissionAccordingToOrganizationID(OrganizationID));
        }

        public IEnumerable<DTO.ClientAndUserbySearchCriterias> GetClientAndUserbySearchCriterias(int OrganizationID, int ClientTypeID, string SelectionTypeName, int SelectionClientTypeID, string SearchText)
        {
            return Mapper.Map<IEnumerable<DTO.ClientAndUserbySearchCriterias>>(_user.GetClientAndUserbySearchCriterias(OrganizationID, ClientTypeID, SelectionTypeName,SelectionClientTypeID, SearchText));
        }
        #endregion

        #region userCardDetail

        public int addUserCardDetail(DTO.UserCardDetail userCardDetail)
        {
            return _userCardDetail.addUserCardDetail(Mapper.Map<DTO.UserCardDetail, HCRGUniversity.Core.Data.Model.UserCardDetail>(userCardDetail));
        }

        public int updateUserCardDetail(DTO.UserCardDetail userCardDetail)
        {
            return _userCardDetail.updateUserCardDetail(Mapper.Map<DTO.UserCardDetail, HCRGUniversity.Core.Data.Model.UserCardDetail>(userCardDetail));
        }

        public DTO.UserCardDetail getUserCardDetailByID(int id)
        {
            return Mapper.Map<DTO.UserCardDetail>(_userCardDetail.getUserCardDetailByID(id));
        }


        public DTO.Paged.PagedUserCardDetail getUserCardDetailByUserID(int userID, int skip, int take)
        {
            return Mapper.Map<DTO.Paged.PagedUserCardDetail>(_userCardDetail.getUserCardDetailByUserID(userID, skip, take));
        }

        #endregion

        #region User Subscription

        public int AddUserSubscription(DTO.UserSubscription userSubscription)
        {
            return _userSubscription.AddUserSubscription(Mapper.Map<DTO.UserSubscription, HCRGUniversity.Core.Data.Model.UserSubscription>(userSubscription));
        }

        public int UpdateUserSubscription(DTO.UserSubscription userSubscription)
        {
            return _userSubscription.UpdateUserSubscription(Mapper.Map<DTO.UserSubscription, HCRGUniversity.Core.Data.Model.UserSubscription>(userSubscription));
        }

        public DTO.UserSubscription GetUserSubscriptionDetails()
        {
            return Mapper.Map<DTO.UserSubscription>(_userSubscription.GetUserSubscriptionDetails());
        }
        public IEnumerable<UserSubscription> GetAllUserSubscriptionByOrganizationID(int OrganizationID, int ClientID)
        {
            return Mapper.Map<IEnumerable<DTO.UserSubscription>>(_userSubscription.GetAllUserSubscriptionByOrganizationID(OrganizationID, ClientID));
        }
        public UserSubscription GetUserSubscriptionByID(int userSubscriptionID)
        {
            return Mapper.Map<UserSubscription>(_userSubscription.GetUserSubscriptionByID(userSubscriptionID));
        }
        #endregion

        #region EnterprisePackageRegister

        public int addEnterprisePackageRegister(DTO.EnterprisePackageRegister EnterprisePackageRegister)
        {
            return _EnterprisePackageRegister.addEnterprisePackageRegister(Mapper.Map<DTO.EnterprisePackageRegister, HCRGUniversity.Core.Data.Model.EnterprisePackageRegister>(EnterprisePackageRegister));
        }
        public int updateEnterprisePackageRegister(DTO.EnterprisePackageRegister EnterprisePackageRegister)
        {
            return _EnterprisePackageRegister.updateEnterprisePackageRegister(Mapper.Map<DTO.EnterprisePackageRegister, HCRGUniversity.Core.Data.Model.EnterprisePackageRegister>(EnterprisePackageRegister));
        }
        public void deleteEnterprisePackageRegister(int id)
        {
            _EnterprisePackageRegister.deleteEnterprisePackageRegister(id);
        }
        public DTO.EnterprisePackageRegister getEnterprisePackageRegisterByID(int id)
        {
            return Mapper.Map<DTO.EnterprisePackageRegister>(_EnterprisePackageRegister.getEnterprisePackageRegisterByID(id));
        }
        //public DTO.EnterprisePackageRegister getEnterprisePackageRegisterByUserID(int userID)
        //{
        //    return Mapper.Map<DTO.EnterprisePackageRegister>(_EnterprisePackageRegister.getEnterprisePackageRegisterByUserID(userID));
        //}
        public DTO.Paged.PagedEnterprisePackageRegister GetAllPagedEnterprisePackageRegister(int skip, int take, int OrganizationID)
        {
            return Mapper.Map<DTO.Paged.PagedEnterprisePackageRegister>(_EnterprisePackageRegister.GetAllEnterprisePackageRegisters(skip, take, OrganizationID));
        }

        public IEnumerable<EnterprisePackageRegister> GetAllEnterprisePackageRegistersByOrganizationID(int OrganizationID)
        {
            return Mapper.Map<IEnumerable<DTO.EnterprisePackageRegister>>(_EnterprisePackageRegister.GetAllEnterprisePackageRegistersByOrganizationID(OrganizationID));
        }
        #endregion


        #region User All Access Pass


        public int addUserAllAccessPass(DTO.UserAllAccessPass userAllAccessPass)
        {
            return _userAllAccessPass.addUserAllAccessPass(Mapper.Map<DTO.UserAllAccessPass, HCRGUniversity.Core.Data.Model.UserAllAccessPass>(userAllAccessPass));
        }
        public int updateUserAllAccessPass(DTO.UserAllAccessPass userAllAccessPass)
        {
            return _userAllAccessPass.updateUserAllAccessPass(Mapper.Map<DTO.UserAllAccessPass, HCRGUniversity.Core.Data.Model.UserAllAccessPass>(userAllAccessPass));
        }

        public DTO.UserAllAccessPass getUserAllAccessPassByID(int id)
        {
            return Mapper.Map<DTO.UserAllAccessPass>(_userAllAccessPass.getUserAllAccessPassByID(id));
        }
        public DTO.UserAllAccessPass getUserAllAccessPassByUserID(int userID)
        {
            return Mapper.Map<DTO.UserAllAccessPass>(_userAllAccessPass.getUserAllAccessPassByUserID(userID));
        }

        public int checkUserAllAccessPassByUserID(int userAllAccessPassID)
        {
            return _userAllAccessPass.checkUserAllAccessPassByUserID(userAllAccessPassID);
        }

        #endregion

        #region User Menu Group
        public DTO.Paged.PagedUserMenuGroup GetUserMenuGroup(int OrganizationID)
        {
            return Mapper.Map<DTO.Paged.PagedUserMenuGroup>(_user.GetUserMenuGroup(OrganizationID));
        }

        public IEnumerable<DTO.UserMenuGroup> GetAllUserMenuGroupByOrganizationID(int OrganizationID)
        {
            return Mapper.Map<IEnumerable<DTO.UserMenuGroup>>(_user.GetAllUserMenuGroupByOrganizationID(OrganizationID));
        }

        public int AddUserMenuGroup(DTO.UserMenuGroup _userMenuGroup)
        {
            return _user.AddUserMenuGroup(Mapper.Map<DTO.UserMenuGroup, HCRGUniversity.Core.Data.Model.UserMenuGroup>(_userMenuGroup));
        }

        public int UpdateUserMenuGroup(DTO.UserMenuGroup _userMenuGroup)
        {
            return _user.UpdateUserMenuGroup(Mapper.Map<DTO.UserMenuGroup, HCRGUniversity.Core.Data.Model.UserMenuGroup>(_userMenuGroup));
        }

        public DTO.UserMenuGroup GetUserMenuGroupByID(int _userMenuGroupID)
        {
            return Mapper.Map<DTO.UserMenuGroup>(_user.GetUserMenuGroupByID(_userMenuGroupID));
        }
        #endregion

        #region User Menu Permission

        public int AddUserMenuPermission(DTO.UserMenuPermission _userMenuPermission)
        {
            return _user.AddUserMenuPermission(Mapper.Map<DTO.UserMenuPermission, HCRGUniversity.Core.Data.Model.UserMenuPermission>(_userMenuPermission));
        }

        public int UpdateUserMenuPermission(DTO.UserMenuPermission _userMenuPermission)
        {
            return _user.UpdateUserMenuPermission(Mapper.Map<DTO.UserMenuPermission, HCRGUniversity.Core.Data.Model.UserMenuPermission>(_userMenuPermission));
        }

        public DTO.UserMenuPermission GetUserMenuPermissionByID(int _userMenuPermissionID)
        {
            return Mapper.Map<DTO.UserMenuPermission>(_user.GetUserMenuPermissionByID(_userMenuPermissionID));
        }

        public DTO.UserMenuPermission GetUserMenuPermissionByUserMenuGroupID(int _userMenuGroupID)
        {
            return Mapper.Map<DTO.UserMenuPermission>(_user.GetUserMenuPermissionByUserMenuGroupID(_userMenuGroupID));
        }

        public DTO.UserMenuGroup GetUserMenuGroupByMenuIDs(string MenuIDs, int OrganizationID)
        {
            return Mapper.Map<DTO.UserMenuGroup>(_user.GetUserMenuGroupByMenuIDs(MenuIDs, OrganizationID));
 
        }

        public DTO.UserMenuGroup GetUserMenuGroupByGroupName(string GroupName, int OrganizationID)
        {
            return Mapper.Map<DTO.UserMenuGroup>(_user.GetUserMenuGroupByGroupName(GroupName, OrganizationID));
        }

        #endregion
        public void UpdateUserSessionIDByUserID(int userId, string userSessionID)
        {
            _user.UpdateUserSessionIDByUserID(userId, userSessionID);
        }
        public void ResetUserSessionID(int UserID)
        {
            _user.ResetUserSessionID(UserID);
        }
    }
}
