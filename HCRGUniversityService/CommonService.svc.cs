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
    public class CommonService : ICommonService
    {
        private readonly IState _state;
        private readonly IOrganizationContact _contact;
        private readonly IShippingMethod _shippingMethod;
        private readonly ISuggestCourse _suggestCourse;
        private readonly IEnterprise _enterprise;
        private readonly IIndustry _industry;
        private readonly IMenu _menu;
        private readonly IClientType _cientType;

        public CommonService(IState state, IShippingMethod shippingMethod, ISuggestCourse suggestCourse, IEnterprise enterprise, IIndustry industry, IOrganizationContact contact, IMenu menu, IClientType cientType)
        {
            _state = state;
            _shippingMethod = shippingMethod;
            _suggestCourse = suggestCourse;
            _enterprise = enterprise;
            _industry = industry;
            _contact = contact;
             _menu = menu;
             _cientType = cientType;
        }

        public IEnumerable<State> getAllState()
        {
            return Mapper.Map<IEnumerable<State>>(_state.getAllState());
        }

        public string getStateByID(int _id)
        {
            return _state.getStateByID(_id);
        }

        public IEnumerable<DTO.ClientType> getAllClientType()
        {
            return Mapper.Map<IEnumerable<ClientType>>(_cientType.getAllClientType());
        }

        public IEnumerable<ShippingMethod> getAllShippingMethod()
        {
            return Mapper.Map<IEnumerable<ShippingMethod>>(_shippingMethod.getAllShippingMethod());
        }

        public IEnumerable<Menu> GetUserMenuByGroupID(int id)
        {
            return Mapper.Map<IEnumerable<Menu>>(_menu.GetUserMenuByGroupID(id));
        }


        public IEnumerable<Menu> getAllMenu()
        {
            return Mapper.Map<IEnumerable<Menu>>(_menu.getAllMenu());
        }

        public IEnumerable<Menu> GetUserMenuBySpecialMenuID(string SpecialMenuIDs)
        {
            return Mapper.Map<IEnumerable<Menu>>(_menu.GetUserMenuBySpecialMenuID(SpecialMenuIDs));
        }


        #region Suggest Course


        public int addSuggestCourse(DTO.SuggestCourse suggestCourse)
        {
            return _suggestCourse.addSuggestCourse(Mapper.Map<DTO.SuggestCourse, HCRGUniversity.Core.Data.Model.SuggestCourse>(suggestCourse));
        }

        public IEnumerable<DTO.SuggestCourse> GetAllSuggestCoursesByOrganizationID(int clientID, int orgID)
        {
            return Mapper.Map<IEnumerable<DTO.SuggestCourse>>(_suggestCourse.GetAllSuggestCoursesByOrganizationID(clientID,orgID));
        }

        public int updateSuggestCourse(DTO.SuggestCourse suggestCourse)
        {
            return _suggestCourse.updateSuggestCourse(Mapper.Map<DTO.SuggestCourse, HCRGUniversity.Core.Data.Model.SuggestCourse>(suggestCourse));
        }
        public DTO.SuggestCourse getSuggestCourseByID(int id)
        {
            return Mapper.Map<DTO.SuggestCourse>(_suggestCourse.getSuggestCourseByID(id));
        }
        public void deleteSuggestCourse(int id)
        {
            _suggestCourse.deleteSuggestCourse(id);
        }

        //public IEnumerable<DTO.SuggestCourse> getSuggestCourseAll()
        //{
        //    return Mapper.Map<IEnumerable<SuggestCourse>>(_suggestCourse.getSuggestCourseAll());
        //}

        public DTO.Paged.PagedSuggestCourse GetAllPagedSuggestCourses(int skip, int take)
        {
            return Mapper.Map<DTO.Paged.PagedSuggestCourse>(_suggestCourse.GetAllSuggestCourses(skip, take));
        }

        #endregion

        #region Enterprise

        public int addEnterprise(DTO.Enterprise enterprise)
        {
            return _enterprise.addEnterprise(Mapper.Map<DTO.Enterprise, HCRGUniversity.Core.Data.Model.Enterprise>(enterprise));
        }
        public int updateEnterprise(DTO.Enterprise enterprise)
        {
            return _enterprise.updateEnterprise(Mapper.Map<DTO.Enterprise, HCRGUniversity.Core.Data.Model.Enterprise>(enterprise));
        }

        public DTO.Enterprise getEnterpriseByID(int _id)
        {
            return Mapper.Map<DTO.Enterprise>(_enterprise.getEnterpriseByID(_id));
        }

        public void deleteEnterpriseByID(int _id)
        {
            _enterprise.deleteEnterpriseByID(_id);
        }

        public IEnumerable<DTO.Enterprise> getEnterpriseAll(int OrganizationID)
        {
            return Mapper.Map<IEnumerable<DTO.Enterprise>>(_enterprise.getEnterpriseAll(OrganizationID));
        }

        public DTO.Paged.PagedEnterpriseDetail getEnterpriseByEnterpriseClientName(string _searchtext, int _skip, int _take, int OrganizationID)
        {
            return Mapper.Map<DTO.Paged.PagedEnterpriseDetail>(_enterprise.getEnterpriseByEnterpriseClientName(_searchtext, _skip, _take, OrganizationID));
        }

        public IEnumerable<DTO.Industry> getAllIndustry()
        {
            return Mapper.Map<IEnumerable<DTO.Industry>>(_industry.getAllIndustry());
        }

        #endregion





    }
}
