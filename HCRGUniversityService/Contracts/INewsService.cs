using System.ServiceModel;
using HCRGUniversityService.DTO;
using System.Collections.Generic;
using HCRGUniversityService.DTO.Paged;
using System;
namespace HCRGUniversityService.Contracts
{
    [ServiceContract]
    public interface INewsService
    {
      
        #region NewsSection service contracts
        [OperationContract]
        int AddNewsSection(NewsSection newsSection);
        [OperationContract]
        int UpdateNewsSection(NewsSection newsSection);
        [OperationContract]
        void DeleteNewsSection(int newsSectionID);
        [OperationContract]
        NewsSection GetNewsSectionByID(int newsSectionID);
        [OperationContract]
        IEnumerable<NewsSection> getAllNewsSection(int OrganizationID); 
        #endregion

     
        #region News service contracts
        [OperationContract]
        int AddNews(News news);
        [OperationContract]
        int UpdateNews(News news);
        [OperationContract]
        void DeleteNews(int newsID);
        [OperationContract]
        News GetNewsByID(int newsID);
        [OperationContract]
        IEnumerable<News> getAllNews(int OrganizationID);
        [OperationContract]
        PagedNews GetNewsByNewsTitlePaged(string newsTitle,int _organizationID, int skip, int take);
        [OperationContract]
        PagedNewsDetail GetAllNewsDetail(string type, int skip, int take, int OrganizationID);
        [OperationContract]
        IEnumerable<NewsFullDetail> GetNewsDetailByNewsID(int newsID, string type);
        [OperationContract]
        PagedNewsDetail GetAllNewsDetailByNewsSectionID(int newsSectionID, int skip, int take);
        [OperationContract]
        PagedNewsDetail GetAllNewsDetailByNewsSectionIDAndType(string type, int newsSectionID, int skip, int take, int OrganizationID);
        [OperationContract]
        IEnumerable<News> GetNewslatest(int OrganizationID); 
         [OperationContract]
         IEnumerable<News> GetAllNewsByOrganizationID(int OrganizationID, int ClientID);
       
        #endregion


     
        #region News Photo contracts
        [OperationContract]
        int AddNewsPhoto(NewsPhoto newsPhoto);
        [OperationContract]
        int UpdateNewsPhoto(NewsPhoto newsPhoto);
        [OperationContract]
        void DeleteNewsPhoto(int newsPhotoID);
        [OperationContract]
        NewsPhoto GetNewsPhotoByID(int newsPhotoID);
        [OperationContract]
        IEnumerable<NewsPhoto> getAllNewsPhoto();
        [OperationContract]
        IEnumerable<NewsPhoto> getAllNewsPhotoByNewsID(int newsID); 
        #endregion

       
        #region News Video Contracts
        [OperationContract]
        int AddNewsVideo(NewsVideo newsVideo);
        [OperationContract]
        int UpdateNewsVideo(NewsVideo newsVideo);
        [OperationContract]
        void DeleteNewsVideo(int newsVideoID);
        [OperationContract]
        NewsVideo GetNewsVideoByID(int newsVideoID);
        [OperationContract]
        IEnumerable<NewsVideo> getAllNewsVideo();
        [OperationContract]
        NewsVideo GetNewsVideoByNewsID(int newsID); 
        #endregion

        //Resources
        [OperationContract]
        IEnumerable<Resource> getAllResource(int OrganizationID);

    
        #region TrainingAndSeminar
		[OperationContract]
        int AddTrainingAndSeminar(TrainingAndSeminar _trainingAndSeminar);
        [OperationContract]
        int UpdateTrainingAndSeminar(TrainingAndSeminar _trainingAndSeminar);
        [OperationContract]
        TrainingAndSeminar GetTrainingAndSeminarAll(int OrganizationID) ;
        [OperationContract]
        IEnumerable<TrainingAndSeminar> GetAllTrainingAndSeminarByOrganizationID(int OrganizationID, int ClientID);
	#endregion;


     
        #region PrivacyPolicy
		[OperationContract]
        int AddPrivacyPolicy(PrivacyPolicy _privacy);
        [OperationContract]
        int UpdatePrivacyPolicy(PrivacyPolicy _privacy);
        [OperationContract]
        PrivacyPolicy GetPrivacyPolicyAll(int ClientID);
        [OperationContract]
        PrivacyPolicy GetPrivacyPolicyByID(int PrivacyPolicyID);
        [OperationContract]
        IEnumerable<PrivacyPolicy> GetAllPrivacyPolicyAccordingToOrganizationID(int OrganizationID, int ClientID);
	#endregion


       
      #region Terms & Condition
		  [OperationContract]
        int AddTermsCondition(TermsCondition _termsCondition);
        [OperationContract]
        int UpdateTermsCondition(TermsCondition _termsCondition);
        [OperationContract]
        TermsCondition GetTermsConditionAll(int ClientID);
        [OperationContract]
        TermsCondition GetTermsConditionByID(int TermsConditionID);
        [OperationContract]
        IEnumerable<TermsCondition> GetAllTermAndConditionsAccordingToClientID(int ClientID); 
	#endregion


      
       #region FAQ method
		 [OperationContract]
        int AddFAQ(FAQ faq);
        [OperationContract]
        int UpdateFAQ(FAQ faq);
        [OperationContract]
        void DeleteFAQ(int faqID);
        [OperationContract]
        FAQ GetFAQByID(int faqID);
        [OperationContract]
        IEnumerable<FAQ> getAllFAQ(int ClientID);
        [OperationContract]
        IEnumerable<FAQ> GetAllFAQAccordingToOrganizationID(int OrganizationID, int ClientID);
	#endregion

   
       #region AQCategory 
		 [OperationContract]
        int AddFAQCategory(FAQCategory faqCategory);
        [OperationContract]
        int UpdateFAQCategory(FAQCategory faqCategory);
        [OperationContract]
        void DeleteFAQCategory(int faqCatID);
        [OperationContract]
        FAQCategory GetFAQCategoryByID(int faqCatID);
        [OperationContract]
        IEnumerable<FAQCategory> GetAllFAQCategoriesAccordingToOrganizationID(int OrganizationID, int ClientID);
        [OperationContract]
        IEnumerable<FAQ> GetFAQByCatID(int faqCatID);
	#endregion


        #region Lazy binding
		[OperationContract]
        PagedNews GetAllPagedNews(int skip, int take, int OrganizationID);

        
	#endregion;



      #region Carousel SetUp
		  [OperationContract]
        int AddCarouselSetup(DTO.CarouselSetUp carouselSetUp);
        [OperationContract]
        IEnumerable<CarouselSetUp> GetCarouselSetUpAll(int OrganizationID);
        [OperationContract]
        IEnumerable<CarouselSetUp> GetAllCarouselSetUp(int OrganizationID, int ClientID);
        [OperationContract]
        IEnumerable<NewsSearchCarousel> GetNewsDetailsAccordingToNewsSearch(string SearchText, int OrganizationID);
        [OperationContract]
        int UpdateCarouselSetUp(DTO.CarouselSetUp carouselSetUp);
        [OperationContract]
        IEnumerable<CarouselSetUp> GetCarouselNewsDetail(int OrganizationID);
        
	#endregion

  
        #region HomeContent
		[OperationContract]
        int AddHomeContent(HomeContent homeContent);
        [OperationContract]
        int UpdateHomeContent(HomeContent homeContent);
        [OperationContract]
        HomeContent GetHomeContent(int OrganizationID); 
        [OperationContract]
        IEnumerable<HomeContent> GetAllHomeContentByOrganizationID(int clientID, int orgID);
	#endregion

     
       #region Events
		 [OperationContract]
        int AddEvent(Event evnt);
        [OperationContract]
        int UpdateEvent(Event evnt);
        [OperationContract]
        void DeleteEvent(int evnt);
        [OperationContract]
        PagedEvents getAllEventsPaged(int skip, int take, int clientID,int orgID);
        [OperationContract]
        IEnumerable<Event> GetEventsByEventDateRange(DateTime startDate, DateTime endDate, int OrganizationID);
        [OperationContract]
        IEnumerable<DTO.Event> GetEventsUpcoming(int OrganizationID); 
	#endregion

     
        #region industryResearch
		[OperationContract]
        int AddIndustryResearchContent(IndustryResearch industryResearchContent);
        [OperationContract]
        int UpdateIndustryResearchContent(IndustryResearch industryResearchContent);
        [OperationContract]
        IndustryResearch GetIndustryResearchContent(int OrganizationID);
        [OperationContract]
        IEnumerable<IndustryResearch> GetAllIndustryResearchesByOrganizationID(int OrganizationID, int ClientID);
	#endregion

       
       #region Accreditation
		 [OperationContract]
        int AddAccreditation(Accreditation _accreditation);
        [OperationContract]
        int UpdateAccreditation(Accreditation _accreditation);
        [OperationContract]
        Accreditation GetAccreditationAll(int OrganizationID);
        [OperationContract]
        IEnumerable<Accreditation> GetAllAccreditationsByOrganizationID(int OrganizationID, int ClientID);
	#endregion


      
     #region Certification
		   [OperationContract]
        int AddCertification(DTO.Certification _Certification);
        [OperationContract]
        int UpdateCertification(DTO.Certification _Certification);
        [OperationContract]
        Certification GetCertificationAll(int OrganizationID);
        [OperationContract]
        IEnumerable<Certification> GetAllCertificationsByOrganizationID(int OrganizationID, int ClientID);
	#endregion


       #region NewsLetter
		 [OperationContract]
        int AddNewsLetter(NewsLetter _newsLetter);
        [OperationContract]
        int UpdateNewsLetter(NewsLetter _newsLetter);
        [OperationContract]
        NewsLetter GetNewsLetterAll(int OrganizationID);
        [OperationContract]
        IEnumerable<NewsLetter> GetNewsLetterByClientID(int clientID,int orgID); 
	#endregion


        #region Return Policy
        [OperationContract]
        int AddReturnPolicy(DTO.ReturnPolicy _returnPolicy);
        [OperationContract]
        int UpdateReturnPolicy(DTO.ReturnPolicy _returnPolicy);
        [OperationContract]
        DTO.ReturnPolicy GetReturnPolicyAll(int ClientID);
        [OperationContract]
        DTO.ReturnPolicy GetReturnPolicyByID(int ReturnPolicyID);
        [OperationContract]
        IEnumerable<ReturnPolicy> GetAllReturnPolicysAccordingToClientID(int ClientID);
        #endregion

        #region Delivery Term
        [OperationContract]
        int AddDeliveryTerm(DTO.DeliveryTerm _deliveryTerm);
        [OperationContract]
        int UpdateDeliveryTerm(DTO.DeliveryTerm _deliveryTerm);
        [OperationContract]
        DTO.DeliveryTerm GetDeliveryTermAll(int ClientID);
        [OperationContract]
        DeliveryTerm GetDeliveryTermByID(int DeliveryTermID);
        [OperationContract]
        IEnumerable<DeliveryTerm> GetAllDeliveryTermsAccordingToClientID(int ClientID);
        #endregion
    }
}