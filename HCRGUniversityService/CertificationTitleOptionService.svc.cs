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
    public class CertificationTitleOptionService : ICertificationTitleOptionService
    {
        private readonly ICertificationTitleOption _certificationTitle;

        public CertificationTitleOptionService(ICertificationTitleOption certificationTitle)
        {
            _certificationTitle = certificationTitle;
        }


        public int AddCertificationTitleOption(DTO.CertificationTitleOption _certificationTitleOption)
        {
            return _certificationTitle.AddCertificationTitleOption(Mapper.Map<DTO.CertificationTitleOption, HCRGUniversity.Core.Data.Model.CertificationTitleOption>(_certificationTitleOption));
        }

        public int UpdateCertificationTitleOption(DTO.CertificationTitleOption _certificationTitleOption)
        {
            return _certificationTitle.UpdateCertificationTitleOption(Mapper.Map<DTO.CertificationTitleOption, HCRGUniversity.Core.Data.Model.CertificationTitleOption>(_certificationTitleOption));
        }

        public void DeleteCertificationTitleOption(int id)
        {
            _certificationTitle.DeleteCertificationTitleOption(id);
        }

        public IEnumerable<CertificationTitleOption> GetAllCertificationTitleOptions()
        {
            return Mapper.Map<IEnumerable<CertificationTitleOption>>(_certificationTitle.GetCertificationTitleOptionsByALL());
        }

        public IEnumerable<CourseNameDropDownList> GetCourseDropDownList(int OrganizationID)
        {
            return Mapper.Map<IEnumerable<CourseNameDropDownList>>(_certificationTitle.GetCourseDropDownList(OrganizationID));
        }

        public CertificationTitleOption GetCertificationTitleOptionsByEducationID(int CertificationTitleOptionID)
        {
            return Mapper.Map<CertificationTitleOption>(_certificationTitle.GetCertificationTitleOptionsByEducationID(CertificationTitleOptionID));
        }

        public CertificationTitleOption GetCertificationTitleOptionsByID(int _educationId)
        {
            return Mapper.Map<CertificationTitleOption>(_certificationTitle.GetCertificationTitleOptionsByID(_educationId));
        }

        public DTO.Paged.PagedCertificationTitleOption GetAllPagedCertificationTitleOption(int skip, int take)
        {
            return Mapper.Map<DTO.Paged.PagedCertificationTitleOption>(_certificationTitle.GetPagedCertificationTitleOption(skip, take));
        }
        
    }
}
