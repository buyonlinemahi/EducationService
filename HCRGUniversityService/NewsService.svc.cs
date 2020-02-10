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
    public class NewsService : INewsService
    {
        private readonly INewsSection _newsSection;
        private readonly INews _news;
        private readonly INewsVideo _newsVideo;
        private readonly INewsPhoto _newsPhoto;
        private readonly IResource _resource;
        private readonly IFAQ _faq;
        private readonly ICarouselSetUp _carouselSetUp;

        public NewsService(INewsSection newsSection, INews news, INewsVideo newsVideo, INewsPhoto newsPhoto, IResource resource, IFAQ faq, ICarouselSetUp carouselSetUp)
        {
            _newsSection = newsSection;
            _news = news;
            _newsVideo = newsVideo;
            _newsPhoto = newsPhoto;
            _resource = resource;
            _faq = faq;
            _carouselSetUp = carouselSetUp;

        }

        #region NewsSection
        public int AddNewsSection(DTO.NewsSection newsSection)
        {
            return _newsSection.AddNewsSection(Mapper.Map<DTO.NewsSection, HCRGUniversity.Core.Data.Model.NewsSection>(newsSection));
        }

        public int UpdateNewsSection(DTO.NewsSection newsSection)
        {
            return _newsSection.UpdateNewsSection(Mapper.Map<DTO.NewsSection, HCRGUniversity.Core.Data.Model.NewsSection>(newsSection));
        }

        public void DeleteNewsSection(int newsSectionID)
        {
            _newsSection.DeleteNewsSection(newsSectionID);
        }

        public NewsSection GetNewsSectionByID(int newsSectionID)
        {
            return Mapper.Map<NewsSection>(_newsSection.GetNewsSectionByID(newsSectionID));
        }

        public IEnumerable<NewsSection> getAllNewsSection(int OrganizationID)
        {
            return Mapper.Map<IEnumerable<NewsSection>>(_newsSection.getAllNewsSection(OrganizationID));
        }
        #endregion



        #region news
        public int AddNews(DTO.News news)
        {
            return _news.AddNews(Mapper.Map<DTO.News, HCRGUniversity.Core.Data.Model.News>(news));
        }

        public int UpdateNews(DTO.News news)
        {
            return _news.UpdateNews(Mapper.Map<DTO.News, HCRGUniversity.Core.Data.Model.News>(news));
        }

        public void DeleteNews(int newsID)
        {
            _news.DeleteNews(newsID);
        }

        public News GetNewsByID(int newsID)
        {
            return Mapper.Map<News>(_news.GetNewsByID(newsID));
        }

        public IEnumerable<News> getAllNews(int OrganizationID)
        {
            return Mapper.Map<IEnumerable<News>>(_news.getAllNews(OrganizationID));
        }

        public IEnumerable<News> GetNewslatest(int OrganizationID)
        {
            return Mapper.Map<IEnumerable<News>>(_news.GetNewslatest(OrganizationID));
        }

        public PagedNews GetNewsByNewsTitlePaged(string newsTitle, int _organizationID, int skip, int take)
        {
            return Mapper.Map<PagedNews>(_news.GetNewsByNewsTitlePaged(newsTitle, _organizationID, skip, take));
        }


        public PagedNewsDetail GetAllNewsDetail(string type, int skip, int take, int OrganizationID)
        {
            return Mapper.Map<PagedNewsDetail>(_news.GetAllNewsDetail(type, skip, take, OrganizationID));
        }

        public IEnumerable<NewsFullDetail> GetNewsDetailByNewsID(int newsID, string type)
        {
            return Mapper.Map<IEnumerable<NewsFullDetail>>(_news.GetNewsDetailByNewsID(newsID, type));
        }

        public PagedNewsDetail GetAllNewsDetailByNewsSectionID(int newsSectionID, int skip, int take)
        {
            return Mapper.Map<PagedNewsDetail>(_news.GetAllNewsDetailByNewsSectionID(newsSectionID, skip, take));
        }

        public PagedNewsDetail GetAllNewsDetailByNewsSectionIDAndType(string type, int newsSectionID, int skip, int take, int OrganizationID)
        {
            return Mapper.Map<PagedNewsDetail>(_news.GetAllNewsDetailByNewsSectionIDAndType(type, newsSectionID, skip, take, OrganizationID));
        }
        public IEnumerable<News> GetAllNewsByOrganizationID(int OrganizationID, int ClientID)
        {
            return Mapper.Map<IEnumerable<DTO.News>>(_news.GetAllNewsByOrganizationID(OrganizationID, ClientID));
        }
        #endregion

        #region NewsVideo
        public int AddNewsVideo(DTO.NewsVideo newsVideo)
        {
            return _newsVideo.AddNewsVideo(Mapper.Map<DTO.NewsVideo, HCRGUniversity.Core.Data.Model.NewsVideo>(newsVideo));
        }

        public int UpdateNewsVideo(DTO.NewsVideo newsVideo)
        {
            return _newsVideo.UpdateNewsVideo(Mapper.Map<DTO.NewsVideo, HCRGUniversity.Core.Data.Model.NewsVideo>(newsVideo));
        }

        public void DeleteNewsVideo(int newsVideoID)
        {
            _newsVideo.DeleteNewsVideo(newsVideoID);
        }

        public NewsVideo GetNewsVideoByID(int newsVideoID)
        {
            return Mapper.Map<NewsVideo>(_newsVideo.GetNewsVideoByID(newsVideoID));
        }

        public IEnumerable<NewsVideo> getAllNewsVideo()
        {
            return Mapper.Map<IEnumerable<NewsVideo>>(_newsVideo.getAllNewsVideo());
        }

        public NewsVideo GetNewsVideoByNewsID(int newsID)
        {
            return Mapper.Map<NewsVideo>(_newsVideo.GetNewsVideoByNewsID(newsID));
        }
        #endregion


        #region NewsPhoto
        public int AddNewsPhoto(DTO.NewsPhoto newsPhoto)
        {
            return _newsPhoto.AddNewsPhoto(Mapper.Map<DTO.NewsPhoto, HCRGUniversity.Core.Data.Model.NewsPhoto>(newsPhoto));
        }

        public int UpdateNewsPhoto(DTO.NewsPhoto newsPhoto)
        {
            return _newsPhoto.UpdateNewsPhoto(Mapper.Map<DTO.NewsPhoto, HCRGUniversity.Core.Data.Model.NewsPhoto>(newsPhoto));
        }

        public void DeleteNewsPhoto(int newsPhotoID)
        {
            _newsPhoto.DeleteNewsPhoto(newsPhotoID);
        }

        public NewsPhoto GetNewsPhotoByID(int newsPhotoID)
        {
            return Mapper.Map<NewsPhoto>(_newsPhoto.GetNewsPhotoByID(newsPhotoID));
        }

        public IEnumerable<NewsPhoto> getAllNewsPhoto()
        {
            return Mapper.Map<IEnumerable<NewsPhoto>>(_newsPhoto.getAllNewsPhoto());
        }

        public IEnumerable<NewsPhoto> getAllNewsPhotoByNewsID(int newsID)
        {
            return Mapper.Map<IEnumerable<NewsPhoto>>(_newsPhoto.getAllNewsPhotoByNewsID(newsID));
        }

        #endregion


        //Resource
        public IEnumerable<Resource> getAllResource(int OrganizationID)
        {
            return Mapper.Map<IEnumerable<Resource>>(_resource.getAllResource(OrganizationID));
        }


        #region TrainingAndSeminar
        public int AddTrainingAndSeminar(DTO.TrainingAndSeminar _trainingAndSeminar)
        {
            return _resource.AddTrainingAndSeminar(Mapper.Map<DTO.TrainingAndSeminar, HCRGUniversity.Core.Data.Model.TrainingAndSeminar>(_trainingAndSeminar));
        }

        public int UpdateTrainingAndSeminar(DTO.TrainingAndSeminar _trainingAndSeminar)
        {
            return _resource.UpdateTrainingAndSeminar(Mapper.Map<DTO.TrainingAndSeminar, HCRGUniversity.Core.Data.Model.TrainingAndSeminar>(_trainingAndSeminar));
        }
        public TrainingAndSeminar GetTrainingAndSeminarAll(int OrganizationID)
        {
            return Mapper.Map<TrainingAndSeminar>(_resource.GetTrainingAndSeminarAll(OrganizationID));
        }
        public IEnumerable<TrainingAndSeminar> GetAllTrainingAndSeminarByOrganizationID(int OrganizationID, int ClientID)
        {
            return Mapper.Map<IEnumerable<DTO.TrainingAndSeminar>>(_resource.GetAllTrainingAndSeminarByOrganizationID(OrganizationID, ClientID));
        }
        #endregion


        #region PrivacyPolicy
        public int AddPrivacyPolicy(PrivacyPolicy _privacy)
        {
            return _resource.AddPrivacyPolicy(Mapper.Map<DTO.PrivacyPolicy, HCRGUniversity.Core.Data.Model.PrivacyPolicy>(_privacy));
        }
        public int UpdatePrivacyPolicy(DTO.PrivacyPolicy _privacy)
        {
            return _resource.UpdatePrivacyPolicy(Mapper.Map<DTO.PrivacyPolicy, HCRGUniversity.Core.Data.Model.PrivacyPolicy>(_privacy));
        }
        public PrivacyPolicy GetPrivacyPolicyAll(int OrganizationID)
        {
            return Mapper.Map<DTO.PrivacyPolicy>(_resource.GetPrivacyPolicyAll(OrganizationID));
        }
        public PrivacyPolicy GetPrivacyPolicyByID(int PrivacyPolicyID)
        {
            return Mapper.Map<DTO.PrivacyPolicy>(_resource.GetPrivacyPolicyByID(PrivacyPolicyID));
        }
        public IEnumerable<PrivacyPolicy> GetAllPrivacyPolicyAccordingToOrganizationID(int OrganizationID, int ClientID)
        {
            return Mapper.Map<IEnumerable<DTO.PrivacyPolicy>>(_resource.GetAllPrivacyPolicyAccordingToOrganizationID(OrganizationID, ClientID));
        }
        #endregion




        #region TermsCondition
        public int AddTermsCondition(DTO.TermsCondition _TermsCondition)
        {
            return _resource.AddTermsCondition(Mapper.Map<DTO.TermsCondition, HCRGUniversity.Core.Data.Model.TermsCondition>(_TermsCondition));
        }
        public int UpdateTermsCondition(DTO.TermsCondition _TermsCondition)
        {
            return _resource.UpdateTermsCondition(Mapper.Map<DTO.TermsCondition, HCRGUniversity.Core.Data.Model.TermsCondition>(_TermsCondition));
        }
        public TermsCondition GetTermsConditionAll(int ClientID)
        {
            return Mapper.Map<DTO.TermsCondition>(_resource.GetTermsConditionAll(ClientID));
        }
        public TermsCondition GetTermsConditionByID(int TermsConditionID)
        {
            return Mapper.Map<DTO.TermsCondition>(_resource.GetTermsConditionByID(TermsConditionID));
        }
        public IEnumerable<TermsCondition> GetAllTermAndConditionsAccordingToClientID(int ClientID)
        {
            return Mapper.Map<IEnumerable<DTO.TermsCondition>>(_resource.GetAllTermAndConditionsAccordingToClientID(ClientID));
        }
        #endregion



        #region FAQ
        public int AddFAQ(FAQ faq)
        {
            return _faq.AddFAQ(Mapper.Map<DTO.FAQ, HCRGUniversity.Core.Data.Model.FAQ>(faq));
        }
        public int UpdateFAQ(FAQ faq)
        {
            return _faq.UpdateFAQ(Mapper.Map<DTO.FAQ, HCRGUniversity.Core.Data.Model.FAQ>(faq));
        }
        public void DeleteFAQ(int faqID)
        {
            _faq.DeleteFAQ(faqID);
        }
        public FAQ GetFAQByID(int faqID)
        {
            return Mapper.Map<FAQ>(_faq.GetFAQByID(faqID));
        }
        public IEnumerable<FAQ> getAllFAQ(int OrganizationID)
        {
            return Mapper.Map<IEnumerable<FAQ>>(_faq.getAllFAQ(OrganizationID));
        }
        public IEnumerable<FAQ> GetFAQByCatID(int faqCatID)
        {
            return Mapper.Map<IEnumerable<FAQ>>(_faq.GetFAQByCatID(faqCatID));
        }

        public int AddFAQCategory(FAQCategory faqCategory)
        {
            return _faq.AddFAQCategory(Mapper.Map<DTO.FAQCategory, HCRGUniversity.Core.Data.Model.FAQCategory>(faqCategory));
        }
        public int UpdateFAQCategory(FAQCategory faqCategory)
        {
            return _faq.UpdateFAQCategory(Mapper.Map<DTO.FAQCategory, HCRGUniversity.Core.Data.Model.FAQCategory>(faqCategory));
        }
        public void DeleteFAQCategory(int faqCatID)
        {
            _faq.DeleteFAQCategory(faqCatID);
        }
        public FAQCategory GetFAQCategoryByID(int faqCatID)
        {
            return Mapper.Map<FAQCategory>(_faq.GetFAQByID(faqCatID));
        }
        public IEnumerable<FAQCategory> GetAllFAQCategoriesAccordingToOrganizationID(int OrganizationID,int ClientID)
        {
            return Mapper.Map<IEnumerable<FAQCategory>>(_faq.GetAllFAQCategoriesAccordingToOrganizationID(OrganizationID, ClientID));
        }
        public IEnumerable<FAQ> GetAllFAQAccordingToOrganizationID(int OrganizationID, int ClientID)
        {
            return Mapper.Map<IEnumerable<FAQ>>(_faq.GetAllFAQAccordingToOrganizationID(OrganizationID, ClientID));
        }
        #endregion


        #region LAzy Binding
        public DTO.Paged.PagedNews GetAllPagedNews(int skip, int take, int OrganizationID)
        {
            return Mapper.Map<DTO.Paged.PagedNews>(_news.GetAllPagedNews(skip, take, OrganizationID));
        }



        #endregion

        #region Carousel SetUp
        public int AddCarouselSetup(DTO.CarouselSetUp carouselSetUp)
        {
            return _carouselSetUp.AddCarouselSetup(Mapper.Map<DTO.CarouselSetUp, HCRGUniversity.Core.Data.Model.CarouselSetUp>(carouselSetUp));
        }

        public IEnumerable<CarouselSetUp> GetCarouselSetUpAll(int OrganizationID)
        {
            return Mapper.Map<IEnumerable<CarouselSetUp>>(_carouselSetUp.GetCarouselSetUpAll(OrganizationID));
        }

        public IEnumerable<CarouselSetUp> GetAllCarouselSetUp(int OrganizationID, int ClientID)
        {
            return Mapper.Map<IEnumerable<CarouselSetUp>>(_carouselSetUp.GetAllCarouselSetUp(OrganizationID, ClientID));
        }

        public IEnumerable<NewsSearchCarousel> GetNewsDetailsAccordingToNewsSearch(string SearchText, int OrganizationID)
        {
            return Mapper.Map<IEnumerable<NewsSearchCarousel>>(_news.GetNewsDetailsAccordingToNewsSearch(SearchText, OrganizationID));
        }

        public int UpdateCarouselSetUp(DTO.CarouselSetUp carouselSetUp)
        {
            return _carouselSetUp.UpdateCarouselSetUp(Mapper.Map<DTO.CarouselSetUp, HCRGUniversity.Core.Data.Model.CarouselSetUp>(carouselSetUp));
        }

        public IEnumerable<CarouselSetUp> GetCarouselNewsDetail(int OrganizationID)
        {
            return Mapper.Map<IEnumerable<CarouselSetUp>>(_carouselSetUp.GetCarouselNewsDetail(OrganizationID));
        }
       
        #endregion


        #region HomeContent
        public int AddHomeContent(DTO.HomeContent homeContent)
        {
            return _carouselSetUp.AddHomeContent(Mapper.Map<DTO.HomeContent, HCRGUniversity.Core.Data.Model.HomeContent>(homeContent));
        }

        public int UpdateHomeContent(DTO.HomeContent homeContent)
        {
            return _carouselSetUp.UpdateHomeContent(Mapper.Map<DTO.HomeContent, HCRGUniversity.Core.Data.Model.HomeContent>(homeContent));
        }

        public HomeContent GetHomeContent(int OrganizationID)
        {
            return Mapper.Map<HomeContent>(_carouselSetUp.GetHomeContent(OrganizationID));
        }
        public IEnumerable<HomeContent> GetAllHomeContentByOrganizationID(int clientID, int orgID)
        {
            return Mapper.Map<IEnumerable<HomeContent>>(_carouselSetUp.GetAllHomeContentByOrganizationID(clientID,orgID));
        }
        #endregion


        #region Events
        public int AddEvent(DTO.Event evnt)
        {
            return _news.AddEvent(Mapper.Map<DTO.Event, HCRGUniversity.Core.Data.Model.Event>(evnt));
        }

        public int UpdateEvent(DTO.Event evnt)
        {
            return _news.UpdateEvent(Mapper.Map<DTO.Event, HCRGUniversity.Core.Data.Model.Event>(evnt));
        }

        public void DeleteEvent(int evntID)
        {
            _news.DeleteEvent(evntID);
        }

        public PagedEvents getAllEventsPaged(int skip, int take, int clientID,int orgID)
        {
            return Mapper.Map<PagedEvents>(_news.getAllEventsPaged(skip, take,clientID,orgID));
        }
        public IEnumerable<Event> GetEventsByEventDateRange(DateTime startDate, DateTime endDate, int OrganizationID)
        {
            return Mapper.Map<IEnumerable<DTO.Event>>(_news.GetEventsByEventDateRange(startDate, endDate, OrganizationID));
        }
        public IEnumerable<DTO.Event> GetEventsUpcoming(int OrganizationID)
        {
            return Mapper.Map<IEnumerable<Event>>(_news.GetEventsUpcoming(OrganizationID));
        }

        #endregion

        #region industry research
        public int AddIndustryResearchContent(IndustryResearch industryResearchContent)
        {
            return _carouselSetUp.AddIndustryResearchContent(Mapper.Map<DTO.IndustryResearch, HCRGUniversity.Core.Data.Model.IndustryResearch>(industryResearchContent));
        }

        public int UpdateIndustryResearchContent(IndustryResearch industryResearchContent)
        {
            return _carouselSetUp.UpdateIndustryResearchContent(Mapper.Map<DTO.IndustryResearch, HCRGUniversity.Core.Data.Model.IndustryResearch>(industryResearchContent));
        }

        public IndustryResearch GetIndustryResearchContent(int OrganizationID)
        {
            return Mapper.Map<DTO.IndustryResearch>(_carouselSetUp.GetIndustryResearchContent(OrganizationID));
        }
        public IEnumerable<IndustryResearch> GetAllIndustryResearchesByOrganizationID(int OrganizationID, int ClientID)
        {
            return Mapper.Map<IEnumerable<DTO.IndustryResearch>>(_carouselSetUp.GetAllIndustryResearchesByOrganizationID(OrganizationID, ClientID));
        }
        #endregion


        #region Accreditation
        public int AddAccreditation(DTO.Accreditation _accreditation)
        {
            return _resource.AddAccreditation(Mapper.Map<DTO.Accreditation, HCRGUniversity.Core.Data.Model.Accreditation>(_accreditation));
        }

        public int UpdateAccreditation(DTO.Accreditation _accreditation)
        {
            return _resource.UpdateAccreditation(Mapper.Map<DTO.Accreditation, HCRGUniversity.Core.Data.Model.Accreditation>(_accreditation));
        }
        public Accreditation GetAccreditationAll(int OrganizationID)
        {
            return Mapper.Map<Accreditation>(_resource.GetAccreditationAll(OrganizationID));
        }
        public IEnumerable<Accreditation> GetAllAccreditationsByOrganizationID(int OrganizationID, int ClientID)
        {
            return Mapper.Map<IEnumerable<DTO.Accreditation>>(_resource.GetAllAccreditationsByOrganizationID(OrganizationID, ClientID));
        }
        #endregion


        #region Certification
        public int AddCertification(DTO.Certification _Certification)
        {
            return _resource.AddCertification(Mapper.Map<DTO.Certification, HCRGUniversity.Core.Data.Model.Certification>(_Certification));
        }

        public int UpdateCertification(DTO.Certification _Certification)
        {
            return _resource.UpdateCertification(Mapper.Map<DTO.Certification, HCRGUniversity.Core.Data.Model.Certification>(_Certification));
        }
        public Certification GetCertificationAll(int OrganizationID)
        {
            return Mapper.Map<Certification>(_resource.GetCertificationAll(OrganizationID));
        }
        public IEnumerable<Certification> GetAllCertificationsByOrganizationID(int OrganizationID, int ClientID)
        {
            return Mapper.Map<IEnumerable<DTO.Certification>>(_resource.GetAllCertificationsByOrganizationID(OrganizationID, ClientID));
        }
        #endregion

        #region NewsLetter
        public int AddNewsLetter(DTO.NewsLetter _newsLetter)
        {
            return _resource.AddNewsLetter(Mapper.Map<DTO.NewsLetter, HCRGUniversity.Core.Data.Model.NewsLetter>(_newsLetter));
        }

        public int UpdateNewsLetter(DTO.NewsLetter _newsLetter)
        {
            return _resource.UpdateNewsLetter(Mapper.Map<DTO.NewsLetter, HCRGUniversity.Core.Data.Model.NewsLetter>(_newsLetter));
        }
        public NewsLetter GetNewsLetterAll(int OrganizationID)
        {
            return Mapper.Map<NewsLetter>(_resource.GetNewsLetterAll(OrganizationID));
        }


        public IEnumerable<NewsLetter> GetNewsLetterByClientID(int clientID,int orgID)
        {
            return Mapper.Map<IEnumerable<DTO.NewsLetter>>(_resource.GetNewsLetterByClientID(clientID,orgID));
        }
        #endregion

        #region Return Policy
        public int AddReturnPolicy(DTO.ReturnPolicy _returnPolicy)
        {
            return _resource.AddReturnPolicy(Mapper.Map<DTO.ReturnPolicy, HCRGUniversity.Core.Data.Model.ReturnPolicy>(_returnPolicy));
        }
        public int UpdateReturnPolicy(DTO.ReturnPolicy _returnPolicy)
        {
            return _resource.UpdateReturnPolicy(Mapper.Map<DTO.ReturnPolicy, HCRGUniversity.Core.Data.Model.ReturnPolicy>(_returnPolicy));
        }
        public DTO.ReturnPolicy GetReturnPolicyAll(int ClientID)
        {
            return Mapper.Map<DTO.ReturnPolicy>(_resource.GetReturnPolicyAll(ClientID));
        }

        public DTO.ReturnPolicy GetReturnPolicyByID(int ReturnPolicyID)
        {
            return Mapper.Map<DTO.ReturnPolicy>(_resource.GetReturnPolicyByID(ReturnPolicyID));
        }
        public IEnumerable<ReturnPolicy> GetAllReturnPolicysAccordingToClientID(int ClientID)
        {
            return Mapper.Map<IEnumerable<DTO.ReturnPolicy>>(_resource.GetAllReturnPolicysAccordingToClientID(ClientID));
        }
        #endregion

        #region Delivery Term
        public int AddDeliveryTerm(DTO.DeliveryTerm _deliveryTerm)
        {
            return _resource.AddDeliveryTerm(Mapper.Map<DTO.DeliveryTerm, HCRGUniversity.Core.Data.Model.DeliveryTerm>(_deliveryTerm));
        }
        public int UpdateDeliveryTerm(DTO.DeliveryTerm _deliveryTerm)
        {
            return _resource.UpdateDeliveryTerm(Mapper.Map<DTO.DeliveryTerm, HCRGUniversity.Core.Data.Model.DeliveryTerm>(_deliveryTerm));
        }
        public DTO.DeliveryTerm GetDeliveryTermAll(int ClientID)
        {
            return Mapper.Map<DTO.DeliveryTerm>(_resource.GetDeliveryTermAll(ClientID));
        }

        public DeliveryTerm GetDeliveryTermByID(int DeliveryTermID)
        {
            return Mapper.Map<DTO.DeliveryTerm>(_resource.GetDeliveryTermByID( DeliveryTermID));
        }
        public IEnumerable<DeliveryTerm> GetAllDeliveryTermsAccordingToClientID(int ClientID)
        {
            return Mapper.Map<IEnumerable<DTO.DeliveryTerm>>(_resource.GetAllDeliveryTermsAccordingToClientID(ClientID));
        }
        #endregion


    }
}