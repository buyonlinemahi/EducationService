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
    public class AboutUsService : IAboutUsService
    {
        private readonly IAboutUs _aboutUs;
        public AboutUsService(IAboutUs aboutUs)
        {
            _aboutUs = aboutUs;
        }

        public int AddAboutUs(DTO.AboutUs aboutUs)
        {
            return _aboutUs.AddAboutUs(Mapper.Map<DTO.AboutUs, HCRGUniversity.Core.BL.Model.About>(aboutUs));
        }

        public int UpdateAboutUs(DTO.AboutUs aboutUs)
        {
            return _aboutUs.UpdateAboutUs(Mapper.Map<DTO.AboutUs, HCRGUniversity.Core.BL.Model.About>(aboutUs));
        }

        public void DeleteAboutUs(int aboutUsID)
        {
            _aboutUs.DeleteAboutUs(aboutUsID);
        }

        public IEnumerable<AboutUs> getAllRecords(int OrganizationID)
        {
            return Mapper.Map<IEnumerable<AboutUs>>(_aboutUs.getAll(OrganizationID));
        }

        public DTO.Paged.PagedAboutUs GetAllPagedAboutus(int skip, int take, int OrganizationID)
        {
            return Mapper.Map<DTO.Paged.PagedAboutUs>(_aboutUs.GetAllPagedAboutus(skip, take, OrganizationID));
        }
        public IEnumerable<AboutUs> GetAllAboutUsByOrganizationID(int OrganizationID, int ClientID)
        {
            return Mapper.Map<IEnumerable<DTO.AboutUs>>(_aboutUs.GetAllAboutUsByOrganizationID(OrganizationID, ClientID));
        }
        

    }
}