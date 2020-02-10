using System.ServiceModel;
using AutoMapper;
using HCRGUniversity.Core.BL;
using HCRGUniversityService.Contracts;
using HCRGUniversityService.CustomServiceBehaviors;
using System.Collections.Generic;
using HCRGUniversityService.DTO;
using HCRGUniversityService.DTO.Paged;
using System;

namespace HCRGUniversityService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    [AutoMapperServiceBehavior]
    public class EducationService : IEducationService
    {
        private readonly IEducation _education;
        private readonly IProfession _profession;
        private readonly IEducationProfession _educationProfession;
        private readonly IEducationFormat _educationFormat;
        private readonly IEducationFormatAvailable _educationFormatAvailable;
        private readonly IEducationCredential _educationCredential;
        public EducationService(IEducation education, IProfession profession, IEducationProfession educationProfession, IEducationFormat educationFormat, IEducationFormatAvailable educationFormatAvailable, IEducationCredential educationCredential)
        {
            _education = education;
            _profession = profession;
            _educationProfession = educationProfession;
            _educationFormat = educationFormat;
            _educationFormatAvailable = educationFormatAvailable;
            _educationCredential = educationCredential;
        }

        public int AddEducation(DTO.Education education)
        {
            return _education.AddEducation(Mapper.Map<DTO.Education, HCRGUniversity.Core.BL.Model.Education>(education));
        }

        public int UpdateEducation(DTO.Education education)
        {
            return _education.UpdateEducation(Mapper.Map<DTO.Education, HCRGUniversity.Core.BL.Model.Education>(education));
        }

        public int PublishEducation(int educationID)
        {
            return _education.PublishEducation(educationID);
        }


        public int CoursePreviewEducation(int educationID)
        {
            return _education.CoursePreviewEducation(educationID);
        }

        public Education GetEducationByID(int educationID)
        {
            return Mapper.Map<Education>(_education.GetEducationByID(educationID));
        }

        public IEnumerable<Education> getAllEducation()
        {
            return Mapper.Map<IEnumerable<Education>>(_education.getAllEducation());
        }

        public IEnumerable<Education> getAllEducationActive()
        {
            return Mapper.Map<IEnumerable<Education>>(_education.getAllEducationActive());
        }

        public IEnumerable<Education> GetEducationLatest(int UserID, int OrganizationID)
        {
            return Mapper.Map<IEnumerable<Education>>(_education.GetEducationLatest(UserID, OrganizationID));
        }

        public PagedEducation GetEducationByEducationNamePaged(string educationName, int skip, int take)
        {
            return Mapper.Map<PagedEducation>(_education.GetEducationByEducationNamePaged(educationName, skip, take));
        }

        public PagedEducation GetEducationReadyToDisplayByEducationNamePaged(string educationName, int _organizationID, int skip, int take)
        {
            return Mapper.Map<PagedEducation>(_education.GetEducationReadyToDisplayByEducationNamePaged(educationName,_organizationID, skip, take));
        }

        public IEnumerable<Education> GetOnSiteEducationByStartDate(DateTime startDate, DateTime endDate)
        {
            return Mapper.Map<IEnumerable<Education>>(_education.GetOnSiteEducationByStartDate(startDate, endDate));
        }

        public IEnumerable<EducationProfessionDetail> GetEducationAndProfession(int OrganizationID)
        {
            return Mapper.Map<IEnumerable<EducationProfessionDetail>>(_education.GetEducationAndProfession(OrganizationID));
        }

        public IEnumerable<EducationFormatDetail> GetEducationAndEducationFormat(int OrganizationID)
        {
            return Mapper.Map<IEnumerable<EducationFormatDetail>>(_education.GetEducationAndEducationFormat(OrganizationID));
        }

        public IEnumerable<CollegeEducationSearch> GetCollegeEducationByEducationID(int educationID)
        {
            return Mapper.Map<IEnumerable<CollegeEducationSearch>>(_education.GetCollegeEducationByEducationID(educationID));
        }

        public IEnumerable<EducationProfessionDetail> GetProfessionEducationByEducationID(int educationID)
        {
            return Mapper.Map<IEnumerable<EducationProfessionDetail>>(_education.GetProfessionEducationByEducationID(educationID));
        }
        //profession service...hp
        public int AddProfession(DTO.Profession profession)
        {
            return _profession.AddProfession(Mapper.Map<DTO.Profession, HCRGUniversity.Core.Data.Model.Profession>(profession));
        }

        public int UpdateProfession(DTO.Profession profession)
        {
            return _profession.UpdateProfession(Mapper.Map<DTO.Profession, HCRGUniversity.Core.Data.Model.Profession>(profession));
        }

        public Profession GetProfessionByID(int professionID)
        {
            return Mapper.Map<Profession>(_profession.GetProfessionByID(professionID));
        }

        public IEnumerable<Profession> getAllProfession(int _clientID)
        {
            return Mapper.Map<IEnumerable<Profession>>(_profession.getAllProfession(_clientID));
        }

        public IEnumerable<Profession> getAllProfessionActive(int _clientID)
        {
            return Mapper.Map<IEnumerable<Profession>>(_profession.getAllProfessionActive(_clientID));
        }

        public IEnumerable<Profession> getAllProfessionWeb(int OrganizationID)
        {
            return Mapper.Map<IEnumerable<Profession>>(_profession.GetAllProfessionWeb(OrganizationID));
        }

        public IEnumerable<Profession> getAllProfessionActiveWeb(int OrganizationID)
        {
            return Mapper.Map<IEnumerable<Profession>>(_profession.GetAllProfessionWebActiveWeb(OrganizationID));
        }

        public IEnumerable<Profession> GetProfessionsByCollegeID(int collegeID)
        {
            return Mapper.Map<IEnumerable<Profession>>(_profession.GetProfessionsByCollegeID(collegeID));
        }

        public IEnumerable<Profession> GetProfessionNotAssociateWithEducation(int educationID)
        {
            return Mapper.Map<IEnumerable<Profession>>(_profession.GetProfessionNotAssociateWithEducation(educationID));
        }

        public DTO.Paged.PagedProfession GetAllPagedProfession(int skip, int take, int _clientID)
        {
            return Mapper.Map<DTO.Paged.PagedProfession>(_profession.GetAllPagedProfession(skip, take, _clientID));
        }
        public DTO.Paged.PagedProfession GetAllPagedProfessionByOrganizationID(int skip, int take, int organizationID)
        {
            return Mapper.Map<DTO.Paged.PagedProfession>(_profession.GetAllPagedProfessionByOrganizationID(skip, take, organizationID));
        }

        //education profession table link methods...hp
        public int AddEducationProfession(EducationProfession educationProfession)
        {
            return _educationProfession.AddEducationProfession(Mapper.Map<DTO.EducationProfession, HCRGUniversity.Core.Data.Model.EducationProfession>(educationProfession));
        }

        public int UpdateEducationProfession(EducationProfession educationProfession)
        {
            return _educationProfession.UpdateEducationProfession(Mapper.Map<DTO.EducationProfession, HCRGUniversity.Core.Data.Model.EducationProfession>(educationProfession));
        }


        //education format methods...hp
        public int AddEducationFormat(EducationFormat educationFormat)
        {
            return _educationFormat.AddEducationFormat(Mapper.Map<DTO.EducationFormat, HCRGUniversity.Core.Data.Model.EducationFormat>(educationFormat));
        }

        public int UpdateEducationFormat(EducationFormat educationFormat)
        {
            return _educationFormat.UpdateEducationFormat(Mapper.Map<DTO.EducationFormat, HCRGUniversity.Core.Data.Model.EducationFormat>(educationFormat));
        }

        public IEnumerable<EducationFormat> getAllEducationFormat(int _organizationID)
        {
            return Mapper.Map<IEnumerable<EducationFormat>>(_educationFormat.getAllEducationFormat(_organizationID));
        }

        public IEnumerable<EducationFormat> GetEducationFormatNotAssociateWithEducation(int educationID)
        {
            return Mapper.Map<IEnumerable<EducationFormat>>(_educationFormat.GetEducationFormatNotAssociateWithEducation(educationID));
        }
        public DTO.Paged.PagedEducationFormat GetAllPagedEducationFormat(int skip, int take)
        {
            return Mapper.Map<DTO.Paged.PagedEducationFormat>(_educationFormat.GetAllPagedEducationFormat(skip, take));
        }

        public IEnumerable<EducationFormat> GetEducationFormatByClientID(int ClientID)
        {
            return Mapper.Map<IEnumerable<EducationFormat>>(_educationFormat.GetEducationFormatByClientID(ClientID));
        }

        public IEnumerable<EducationFormat> GetAllEducationFormatByClientID(int ClientID)
        {
            return Mapper.Map<IEnumerable<EducationFormat>>(_educationFormat.GetAllEducationFormatByClientID(ClientID));
        }

        public IEnumerable<EducationFormat> GetAllEducationFormatByOrganizationID(int _organizationID)
        {
            return Mapper.Map<IEnumerable<EducationFormat>>(_educationFormat.GetAllEducationFormatByOrganizationID(_organizationID));
        }

        //education format table link methods...hp
        public int AddEducationFormatAvailable(EducationFormatAvailable educationFormatAvailable)
        {
            return _educationFormatAvailable.AddEducationFormatAvailable(Mapper.Map<DTO.EducationFormatAvailable, HCRGUniversity.Core.Data.Model.EducationFormatAvailable>(educationFormatAvailable));
        }

        public int UpdateEducationFormatAvailable(EducationFormatAvailable educationFormatAvailable)
        {
            return _educationFormatAvailable.UpdateEducationFormatAvailable(Mapper.Map<DTO.EducationFormatAvailable, HCRGUniversity.Core.Data.Model.EducationFormatAvailable>(educationFormatAvailable));
        }

        public IEnumerable<EducationFormatDetail> GetEducationFormatsByEducationID(int educationID)
        {
            return Mapper.Map<IEnumerable<EducationFormatDetail>>(_educationFormatAvailable.GetEducationFormatsByEducationID(educationID));
        }


        //link college Education and education in collegeEduction table...hp
        public int AddCollegeEducation(CollegeEducation cEdu)
        {
            return _education.AddCollegeEducation(Mapper.Map<DTO.CollegeEducation, HCRGUniversity.Core.Data.Model.CollegeEducation>(cEdu));
        }

        public int UpdateCollegeEducation(CollegeEducation cEdu)
        {
            return _education.UpdateCollegeEducation(Mapper.Map<DTO.CollegeEducation, HCRGUniversity.Core.Data.Model.CollegeEducation>(cEdu));
        }

        //get data from stored procedure for all education page......hp
        public DTO.Paged.PagedEducation GetEducationCollegeAllPaged(int skip, int take)
        {
            return Mapper.Map<DTO.Paged.PagedEducation>(_education.GetEducationCollegeAllPaged(skip, take));
        }

        public DTO.Paged.PagedEducation GetEducationCollegeByCollegeIDPaged(int collegeID, int? userID, int skip, int take, int OrganizationID)
        {
            return Mapper.Map<DTO.Paged.PagedEducation>(_education.GetEducationCollegeByCollegeIDPaged(collegeID, userID, skip, take, OrganizationID));
        }

        public DTO.Paged.PagedEducation GetEducationCollegeByEducationFormatIDPaged(int formatID, int? userID, int skip, int take, int OrganizationID)
        {
            return Mapper.Map<DTO.Paged.PagedEducation>(_education.GetEducationCollegeByEducationFormatIDPaged(formatID, userID, skip, take, OrganizationID));
        }

        public DTO.Paged.PagedEducation GetEducationCollegeByEducationFormatIDAndCollegeIDPaged(int collegeID, int formatID, int? userID, int skip, int take, int OrganizationID)
        {
            return Mapper.Map<DTO.Paged.PagedEducation>(_education.GetEducationCollegeByEducationFormatIDAndCollegeIDPaged(collegeID, formatID, userID, skip, take, OrganizationID));
        }

        public DTO.Paged.PagedEducation GetEducationByProfessionIDPaged(int professionID, int? userID, int skip, int take, int OrganizationID)
        {
            return Mapper.Map<DTO.Paged.PagedEducation>(_education.GetEducationByProfessionIDPaged(professionID, userID, skip, take, OrganizationID));
        }

        public DTO.Paged.PagedEducation GetEducationByEducationFormatIDORCollegeIDORDeptIDORPrfIDPaged(int? collegeID, int? formatID, int? professionID, int? userID, int skip, int take, int OrganizationID)
        {
            return Mapper.Map<DTO.Paged.PagedEducation>(_education.GetEducationByEducationFormatIDORCollegeIDORDeptIDORPrfIDPaged(collegeID, formatID, professionID, userID, skip, take, OrganizationID));
        }

        //end page

        public DTO.Paged.PagedEducationNewsSearch GetEducationNewsSearchByTextPaged(string searchText, int? userid, int OrganizationID ,int skip, int take)
        {
            return Mapper.Map<DTO.Paged.PagedEducationNewsSearch>(_education.GetEducationNewsSearchByTextPaged(searchText, userid, OrganizationID, skip, take));
        }

        //add education type....hp
        public int AddEducationType(DTO.EducationTypesAvailable educationTypesAvailable)
        {
            return _education.AddEducationType(Mapper.Map<DTO.EducationTypesAvailable, HCRGUniversity.Core.Data.Model.EducationTypesAvailable>(educationTypesAvailable));
        }

        public int UpdateEducationType(DTO.EducationTypesAvailable educationTypesAvailable)
        {
            return _education.UpdateEducationType(Mapper.Map<DTO.EducationTypesAvailable, HCRGUniversity.Core.Data.Model.EducationTypesAvailable>(educationTypesAvailable));
        }

        public IEnumerable<EducationTypesAvailable> GetEducationTypeByEducationID(int educationID)
        {
            return Mapper.Map<IEnumerable<EducationTypesAvailable>>(_education.GetEducationTypeByEducationID(educationID));
        }

        //add and update education detail page for each education...hp
        public int AddEducationDetailPageContent(EducationDetailPage eduDetailPage)
        {
            return _education.AddEducationDetailPageContent(Mapper.Map<DTO.EducationDetailPage, HCRGUniversity.Core.Data.Model.EducationDetailPage>(eduDetailPage));
        }
        public int UpdateEducationDetailPageContent(EducationDetailPage eduDetailPage)
        {
            return _education.UpdateEducationDetailPageContent(Mapper.Map<DTO.EducationDetailPage, HCRGUniversity.Core.Data.Model.EducationDetailPage>(eduDetailPage));
        }
        public EducationDetailPageWithEducation GetEducationDetailPageContent(int educationID)
        {
            return Mapper.Map<DTO.EducationDetailPageWithEducation>(_education.GetEducationDetailPageContent(educationID));
        }

        //lazy binding
        public DTO.Paged.PagedEducationProfession GetAllPagedEducationProfession(int skip, int take, int OrganizationID)
        {
            return Mapper.Map<DTO.Paged.PagedEducationProfession>(_education.GetAllPagedEducationProfession(skip, take, OrganizationID));
        }

        //LAzy Binding
        public DTO.Paged.PagedEducation GetAllPagedEducationByfilter(string coursename, int skip, int take, int ClientID,int OrgID)
        {
            return Mapper.Map<DTO.Paged.PagedEducation>(_education.GetAllPagedEducationByfilter(coursename, skip, take, ClientID,OrgID));
        }

        //LAzy Binding
        public DTO.Paged.PagedEducation GetCourseCatalogByfilter(string _search, int skip, int take, int ClientID, int OrgID)
        {
            return Mapper.Map<DTO.Paged.PagedEducation>(_education.GetCourseCatalogByfilter(_search, skip, take, ClientID, OrgID));
        }

        //---Accreditor
        public int AddAccreditor(DTO.Accreditor accreditor)
        {
            return _educationCredential.AddAccreditor(Mapper.Map<DTO.Accreditor, HCRGUniversity.Core.Data.Model.Accreditor>(accreditor));
        }

        public int UpdateAccreditor(DTO.Accreditor accreditor)
        {
            return _educationCredential.UpdateAccreditor(Mapper.Map<DTO.Accreditor, HCRGUniversity.Core.Data.Model.Accreditor>(accreditor));
        }

        public void DeleteAccreditor(int accreditorID, bool isActive)
        {
            _educationCredential.DeleteAccreditor(accreditorID, isActive);
        }

        public IEnumerable<Accreditor> getAll()
        {
            return Mapper.Map<IEnumerable<Accreditor>>(_educationCredential.getAll());
        }

        public DTO.Paged.PagedAccreditor GetAllPagedAccreditor(int skip, int take)
        {
            return Mapper.Map<DTO.Paged.PagedAccreditor>(_educationCredential.GetAllPagedAccreditor(skip, take));
        }

        public IEnumerable<Accreditor> GetAllAccreditorsByOrganizationID(int clientID, int orgID)
        {
            return Mapper.Map<IEnumerable<Accreditor>>(_educationCredential.GetAllAccreditorsByOrganizationID(clientID, orgID));
        }
        //---education credential..
        public int AddEducationCredential(DTO.EducationCredential educationCredential)
        {
            return _educationCredential.AddEducationCredential(Mapper.Map<DTO.EducationCredential, HCRGUniversity.Core.Data.Model.EducationCredential>(educationCredential));
        }

        public int UpdateEducationCredential(DTO.EducationCredential educationCredential)
        {
            return _educationCredential.UpdateEducationCredential(Mapper.Map<DTO.EducationCredential, HCRGUniversity.Core.Data.Model.EducationCredential>(educationCredential));
        }

        public void DeleteEducationCredential(int _credentialID, bool isActive)
        {
            _educationCredential.DeleteEducationCredential(_credentialID, isActive);
        }

        public EducationCredential GetEducationCredentialByID(int _credentialID)
        {
            return Mapper.Map<EducationCredential>(_educationCredential.GetEducationCredentialByID(_credentialID));
        }

        public IEnumerable<EducationCredential> GetEducationCredentialByEducationID(int _educationID)
        {
            return Mapper.Map<IEnumerable<EducationCredential>>(_educationCredential.GetEducationCredentialByEducationID(_educationID));
        }

        public IEnumerable<EducationCredential> GetEducationCredentialDetailByEducationID(int _educationID)
        {
            return Mapper.Map<IEnumerable<EducationCredential>>(_educationCredential.GetEducationCredentialDetailByEducationID(_educationID));
        }

        public IEnumerable<CourseExpirySendEmail> GETCourseExpirySendEmailAlert(int OrganizationID)
        {
            return Mapper.Map<IEnumerable<CourseExpirySendEmail>>(_education.GETCourseExpirySendEmailAlert(OrganizationID));
        }

        public void UpdateMyEducationCompletedToPassed(int educationID)
        {
            _education.UpdateMyEducationCompletedToPassed(educationID);
        }
        //Update Education Modules Time in admin preview course.
        public void UpdateEducationModulesTime(int educationID)
        {
            _education.UpdateEducationModulesTime(educationID);
        }

        public IEnumerable<DTO.Education> GetEducationByClientID(int ClientID)
        {
            return Mapper.Map<IEnumerable<DTO.Education>>(_education.GetEducationByClientID(ClientID));
        }
    }
}