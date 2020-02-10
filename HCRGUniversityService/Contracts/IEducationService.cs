using System.ServiceModel;
using HCRGUniversityService.DTO;
using System.Collections.Generic;
using HCRGUniversityService.DTO.Paged;
using System;
namespace HCRGUniversityService.Contracts
{
    [ServiceContract]
    public interface IEducationService
    {
        [OperationContract]
        int AddEducation(Education education);

        [OperationContract]
        int UpdateEducation(Education education);

        [OperationContract]
        Education GetEducationByID(int educationID);

        [OperationContract]
        IEnumerable<Education> getAllEducation();

        [OperationContract]
        IEnumerable<Education> getAllEducationActive();

        [OperationContract]
        IEnumerable<Education> GetEducationLatest(int UserID, int OrganizationID);

        [OperationContract]
        PagedEducation GetEducationByEducationNamePaged(string educationName, int skip, int take);

        [OperationContract]
        PagedEducation GetEducationReadyToDisplayByEducationNamePaged(string educationName, int _organizationID, int skip, int take);

        [OperationContract]
        IEnumerable<Education> GetOnSiteEducationByStartDate(DateTime startDate, DateTime endDate);

         [OperationContract]
        int PublishEducation(int educationID);

         [OperationContract]
         int CoursePreviewEducation(int educationID);

        [OperationContract]
         IEnumerable<EducationProfessionDetail> GetEducationAndProfession(int OrganizationID);

        [OperationContract]
        IEnumerable<EducationFormatDetail> GetEducationAndEducationFormat(int OrganizationID);

        [OperationContract]
        IEnumerable<CollegeEducationSearch> GetCollegeEducationByEducationID(int educationID);

        [OperationContract]
        IEnumerable<EducationProfessionDetail> GetProfessionEducationByEducationID(int educationID);


        //profession service contracts...hp
        [OperationContract]
        int AddProfession(Profession profession);

        [OperationContract]
        int UpdateProfession(Profession profession);

        [OperationContract]
        Profession GetProfessionByID(int professionID);

        [OperationContract]
        IEnumerable<Profession> getAllProfession(int _clientID);

        [OperationContract]
        IEnumerable<Profession> getAllProfessionActive(int _clientID);


        [OperationContract]
        IEnumerable<Profession> getAllProfessionWeb(int OrganizationID);

        [OperationContract]
        IEnumerable<Profession> getAllProfessionActiveWeb(int OrganizationID);

        [OperationContract]
        IEnumerable<Profession> GetProfessionsByCollegeID(int collegeID);

        [OperationContract]
        IEnumerable<Profession> GetProfessionNotAssociateWithEducation(int educationID);

        [OperationContract]
        PagedProfession GetAllPagedProfession(int skip, int take, int _clientID);

        [OperationContract]
        PagedProfession GetAllPagedProfessionByOrganizationID(int skip, int take, int organizationID);

        //education profession table link methods...hp
        [OperationContract]
        int AddEducationProfession(EducationProfession educationProfession);
        [OperationContract]
        int UpdateEducationProfession(EducationProfession educationProfession);

        //education format methods...hp
        [OperationContract]
        int AddEducationFormat(EducationFormat educationFormat);
        [OperationContract]
        int UpdateEducationFormat(EducationFormat educationFormat);
        [OperationContract]
        IEnumerable<EducationFormat> getAllEducationFormat(int _organizationID);
        [OperationContract]
        IEnumerable<EducationFormat> GetEducationFormatNotAssociateWithEducation(int educationID);
        [OperationContract]
        PagedEducationFormat GetAllPagedEducationFormat(int skip, int take);
        [OperationContract]
        IEnumerable<EducationFormat> GetEducationFormatByClientID(int ClientID);
        [OperationContract]
        IEnumerable<EducationFormat> GetAllEducationFormatByClientID(int ClientID);
        [OperationContract]
        IEnumerable<EducationFormat> GetAllEducationFormatByOrganizationID(int _organizationID);

        //education format table link methods...hp
        [OperationContract]
        int AddEducationFormatAvailable(EducationFormatAvailable educationFormatAvailable);
        [OperationContract]
        int UpdateEducationFormatAvailable(EducationFormatAvailable educationFormatAvailable);
        [OperationContract]
        IEnumerable<EducationFormatDetail> GetEducationFormatsByEducationID(int educationID);

        //link college Education and education in collegeEduction table...hp
        [OperationContract]
        int AddCollegeEducation(CollegeEducation cEdu);
        [OperationContract]
        int UpdateCollegeEducation(CollegeEducation cEdu);

        //get data from stored procedure for all education page......hp
        [OperationContract]
        DTO.Paged.PagedEducation GetEducationCollegeAllPaged(int skip, int take);
        [OperationContract]
        DTO.Paged.PagedEducation GetEducationCollegeByCollegeIDPaged(int collegeID, int? userID, int skip, int take, int OrganizationID);
        [OperationContract]
        DTO.Paged.PagedEducation GetEducationCollegeByEducationFormatIDPaged(int formatID, int? userID, int skip, int take, int OrganizationID);
        [OperationContract]
        DTO.Paged.PagedEducation GetEducationCollegeByEducationFormatIDAndCollegeIDPaged(int collegeID, int formatID, int? userID, int skip, int take, int OrganizationID);
        [OperationContract]
        DTO.Paged.PagedEducation GetEducationByProfessionIDPaged(int professionID, int? userID, int skip, int take, int OrganizationID);
        [OperationContract]
        DTO.Paged.PagedEducation GetEducationByEducationFormatIDORCollegeIDORDeptIDORPrfIDPaged(int? collegeID, int? formatID, int? professionID, int? UserID, int skip, int take, int OrganizationID);

        [OperationContract]
        DTO.Paged.PagedEducationNewsSearch GetEducationNewsSearchByTextPaged(string searchText, int? UserID, int OrganizationID, int skip, int take); 

        [OperationContract]
        int AddEducationType(EducationTypesAvailable educationTypesAvailable);

        [OperationContract]
        int UpdateEducationType(EducationTypesAvailable educationTypesAvailable);

        [OperationContract]
        IEnumerable<EducationTypesAvailable> GetEducationTypeByEducationID(int educationID);

        //add and update education detail page for each education...hp
        [OperationContract]
        int AddEducationDetailPageContent(EducationDetailPage eduDetailPage);
        [OperationContract]
        int UpdateEducationDetailPageContent(EducationDetailPage eduDetailPage);
        [OperationContract]
        EducationDetailPageWithEducation GetEducationDetailPageContent(int educationID);

        ///Lazy bindng
        [OperationContract]
        PagedEducationProfession GetAllPagedEducationProfession(int skip, int take, int OrganizationID);

        [OperationContract]
        PagedEducation GetAllPagedEducationByfilter(string coursename, int skip, int take, int ClientID,int OrgID);
        [OperationContract]
        DTO.Paged.PagedEducation GetCourseCatalogByfilter(string _search, int skip, int take, int ClientID, int OrgID);

        //---Accreditor
        [OperationContract]
        int AddAccreditor(Accreditor accreditor);
        [OperationContract]
        int UpdateAccreditor(Accreditor accreditor);
        [OperationContract]
        void DeleteAccreditor(int _accreditorID,bool isActive);
        [OperationContract]
        IEnumerable<Accreditor> getAll();
        [OperationContract]
        PagedAccreditor GetAllPagedAccreditor(int skip, int take);
        [OperationContract]
        IEnumerable<Accreditor> GetAllAccreditorsByOrganizationID(int clientID, int orgID);

        //--EducationCredential
        [OperationContract]
        int AddEducationCredential(EducationCredential educationCredential);
        [OperationContract]
        int UpdateEducationCredential(EducationCredential educationCredential);
        [OperationContract]
        void DeleteEducationCredential(int _credentialID,bool isActive);
        [OperationContract]
        EducationCredential GetEducationCredentialByID(int _credentialID);
        [OperationContract]
        IEnumerable<EducationCredential> GetEducationCredentialByEducationID(int _educationID);
        [OperationContract]
        IEnumerable<EducationCredential> GetEducationCredentialDetailByEducationID(int _educationID);
        [OperationContract]
        IEnumerable<CourseExpirySendEmail> GETCourseExpirySendEmailAlert(int OrganizationID);
        [OperationContract]
        void UpdateMyEducationCompletedToPassed(int educationID);
        [OperationContract]
        void UpdateEducationModulesTime(int educationID);
        [OperationContract]
        IEnumerable<DTO.Education> GetEducationByClientID(int ClientID);
    }
}