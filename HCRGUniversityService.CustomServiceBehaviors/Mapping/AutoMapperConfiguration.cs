using AutoMapper;
using HCRGUniversityService;

namespace HCRGUniversityService.CustomServiceBehaviors.Mapping
{
    public static class AutoMapperConfiguration
    {
        public static void Init()
        {
            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.User, DTO.User>();
            Mapper.CreateMap<DTO.User, HCRGUniversity.Core.BL.Model.User>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.About, DTO.AboutUs>();
            Mapper.CreateMap<DTO.AboutUs, HCRGUniversity.Core.BL.Model.About>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.College, DTO.College>();
            Mapper.CreateMap<DTO.College, HCRGUniversity.Core.BL.Model.College>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.CarouselSetUp, DTO.CarouselSetUp>();
            Mapper.CreateMap<DTO.CarouselSetUp, HCRGUniversity.Core.Data.Model.CarouselSetUp>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.CarouselSetUp, DTO.CarouselSetUp>();
            Mapper.CreateMap<DTO.CarouselSetUp, HCRGUniversity.Core.BL.Model.CarouselSetUp>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.Menu, DTO.Menu>();
            Mapper.CreateMap<DTO.Menu, HCRGUniversity.Core.Data.Model.Menu>();


            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.CertificationTitleOption, DTO.CertificationTitleOption>();
            Mapper.CreateMap<DTO.CertificationTitleOption, HCRGUniversity.Core.BL.Model.CertificationTitleOption>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.CertificationTitleOption, DTO.CertificationTitleOption>();
            Mapper.CreateMap<DTO.CertificationTitleOption, HCRGUniversity.Core.Data.Model.CertificationTitleOption>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.CourseNameDropDownList, DTO.CourseNameDropDownList>();
            Mapper.CreateMap<DTO.CourseNameDropDownList, HCRGUniversity.Core.Data.Model.CourseNameDropDownList>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.NewsSearchCarousel, DTO.NewsSearchCarousel>();
            Mapper.CreateMap<DTO.NewsSearchCarousel, HCRGUniversity.Core.Data.Model.NewsSearchCarousel>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.CollegeEducationSearch, DTO.CollegeEducationSearch>();
            Mapper.CreateMap<DTO.CollegeEducationSearch, HCRGUniversity.Core.Data.Model.CollegeEducationSearch>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Education, DTO.Education>();
            Mapper.CreateMap<DTO.Education, HCRGUniversity.Core.BL.Model.Education>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.Profession, DTO.Profession>();
            Mapper.CreateMap<DTO.Profession, HCRGUniversity.Core.Data.Model.Profession>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Profession, DTO.Profession>();
            Mapper.CreateMap<DTO.Profession, HCRGUniversity.Core.BL.Model.Profession>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.EducationProfession, DTO.EducationProfession>();
            Mapper.CreateMap<DTO.EducationProfession, HCRGUniversity.Core.Data.Model.EducationProfession>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.EducationProfessionDetail, DTO.EducationProfessionDetail>();
            Mapper.CreateMap<DTO.EducationProfessionDetail, HCRGUniversity.Core.Data.Model.EducationProfessionDetail>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.EducationFormat, DTO.EducationFormat>();
            Mapper.CreateMap<DTO.EducationFormat, HCRGUniversity.Core.Data.Model.EducationFormat>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.EducationFormat, DTO.EducationFormat>();
            Mapper.CreateMap<DTO.EducationFormat, HCRGUniversity.Core.BL.Model.EducationFormat>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.EducationFormatAvailable, DTO.EducationFormatAvailable>();
            Mapper.CreateMap<DTO.EducationFormatAvailable, HCRGUniversity.Core.Data.Model.EducationFormatAvailable>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.CollegeEducation, DTO.CollegeEducation>();
            Mapper.CreateMap<DTO.CollegeEducation, HCRGUniversity.Core.Data.Model.CollegeEducation>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.EducationDetail, DTO.EducationDetail>();
            Mapper.CreateMap<DTO.EducationDetail, HCRGUniversity.Core.Data.Model.EducationDetail>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.EducationDetailPageWithEducation, DTO.EducationDetailPageWithEducation>();
            Mapper.CreateMap<DTO.EducationDetailPageWithEducation, HCRGUniversity.Core.Data.Model.EducationDetailPageWithEducation>();
            

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.EducationTypesAvailable, DTO.EducationTypesAvailable>();
            Mapper.CreateMap<DTO.EducationTypesAvailable, HCRGUniversity.Core.Data.Model.EducationTypesAvailable>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.EducationShoppingTemp, DTO.EducationShoppingTemp>();
            Mapper.CreateMap<DTO.EducationShoppingTemp, HCRGUniversity.Core.Data.Model.EducationShoppingTemp>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.EducationShoppingCart, DTO.EducationShoppingCart>();
            Mapper.CreateMap<DTO.EducationShoppingCart, HCRGUniversity.Core.Data.Model.EducationShoppingCart>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.EducationDetailPage, DTO.EducationDetailPage>();
            Mapper.CreateMap<DTO.EducationDetailPage, HCRGUniversity.Core.Data.Model.EducationDetailPage>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.DiscountCoupon, DTO.DiscountCoupon>();
            Mapper.CreateMap<DTO.DiscountCoupon, HCRGUniversity.Core.BL.Model.DiscountCoupon>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.DiscountCouponForCourses, DTO.DiscountCouponForCourses>();
            Mapper.CreateMap<DTO.DiscountCouponForCourses, HCRGUniversity.Core.Data.Model.DiscountCouponForCourses>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.EducationFormatDetail, DTO.EducationFormatDetail>();
            Mapper.CreateMap<DTO.EducationFormatDetail, HCRGUniversity.Core.Data.Model.EducationFormatDetail>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.NewsSection, DTO.NewsSection>();
            Mapper.CreateMap<DTO.NewsSection, HCRGUniversity.Core.Data.Model.NewsSection>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.News, DTO.News>();
            Mapper.CreateMap<DTO.News, HCRGUniversity.Core.Data.Model.News>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.News, DTO.News>();
            Mapper.CreateMap<DTO.News, HCRGUniversity.Core.BL.Model.News>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.NewsVideo, DTO.NewsVideo>();
            Mapper.CreateMap<DTO.NewsVideo, HCRGUniversity.Core.Data.Model.NewsVideo>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.NewsPhoto, DTO.NewsPhoto>();
            Mapper.CreateMap<DTO.NewsPhoto, HCRGUniversity.Core.Data.Model.NewsPhoto>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.Resource, DTO.Resource>();
            Mapper.CreateMap<DTO.Resource, HCRGUniversity.Core.Data.Model.Resource>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.NewsFullDetail, DTO.NewsFullDetail>();
            Mapper.CreateMap<DTO.NewsFullDetail, HCRGUniversity.Core.Data.Model.NewsFullDetail>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.EducationModule, DTO.EducationModule>();
            Mapper.CreateMap<DTO.EducationModule, HCRGUniversity.Core.Data.Model.EducationModule>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.EducationModuleFile, DTO.EducationModuleFile>();
            Mapper.CreateMap<DTO.EducationModuleFile, HCRGUniversity.Core.Data.Model.EducationModuleFile>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.FileType, DTO.FileType>();
            Mapper.CreateMap<DTO.FileType, HCRGUniversity.Core.Data.Model.FileType>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.EducationSearchResult, DTO.EducationSearchResult>();
            Mapper.CreateMap<DTO.EducationSearchResult, HCRGUniversity.Core.Data.Model.EducationSearchResult>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.EducationShopping, DTO.EducationShopping>();
            Mapper.CreateMap<DTO.EducationShopping, HCRGUniversity.Core.Data.Model.EducationShopping>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.MyEducationDetail, DTO.MyEducationDetail>();
            Mapper.CreateMap<DTO.MyEducationDetail, HCRGUniversity.Core.Data.Model.MyEducationDetail>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.MyEducationModuleDetail, DTO.MyEducationModuleDetail>();
            Mapper.CreateMap<DTO.MyEducationModuleDetail, HCRGUniversity.Core.Data.Model.MyEducationModuleDetail>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.MyEducationModule, DTO.MyEducationModule>();
            Mapper.CreateMap<DTO.MyEducationModule, HCRGUniversity.Core.Data.Model.MyEducationModule>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.FAQDetail, DTO.FAQ>();
            Mapper.CreateMap<DTO.FAQ, HCRGUniversity.Core.Data.Model.FAQDetail>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.FAQ, DTO.FAQ>();
            Mapper.CreateMap<DTO.FAQ, HCRGUniversity.Core.Data.Model.FAQ>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.FAQ, DTO.FAQ>();
            Mapper.CreateMap<DTO.FAQ, HCRGUniversity.Core.BL.Model.FAQ>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.FAQCategory, DTO.FAQCategory>();
            Mapper.CreateMap<DTO.FAQCategory, HCRGUniversity.Core.BL.Model.FAQCategory>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.FAQCategory, DTO.FAQCategory>();
            Mapper.CreateMap<DTO.FAQCategory, HCRGUniversity.Core.Data.Model.FAQCategory>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.ExamQuestion, DTO.ExamQuestion>();
            Mapper.CreateMap<DTO.ExamQuestion, HCRGUniversity.Core.Data.Model.ExamQuestion>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.PreTestQuestion, DTO.PreTestQuestion>();
            Mapper.CreateMap<DTO.PreTestQuestion, HCRGUniversity.Core.Data.Model.PreTestQuestion>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.EducationExamQuestion, DTO.EducationExamQuestion>();
            Mapper.CreateMap<DTO.EducationExamQuestion, HCRGUniversity.Core.Data.Model.EducationExamQuestion>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.EducationPreTestQuestion, DTO.EducationPreTestQuestion>();
            Mapper.CreateMap<DTO.EducationPreTestQuestion, HCRGUniversity.Core.Data.Model.EducationPreTestQuestion>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.Exam, DTO.Exam>();
            Mapper.CreateMap<DTO.Exam, HCRGUniversity.Core.Data.Model.Exam>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Exam, DTO.Exam>();
            Mapper.CreateMap<DTO.Exam, HCRGUniversity.Core.BL.Model.Exam>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.PreTest, DTO.PreTest>();
            Mapper.CreateMap<DTO.PreTest, HCRGUniversity.Core.Data.Model.PreTest>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.PreTest, DTO.PreTest>();
            Mapper.CreateMap<DTO.PreTest, HCRGUniversity.Core.BL.Model.PreTest>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.Evaluation, DTO.Evaluation>();
            Mapper.CreateMap<DTO.Evaluation, HCRGUniversity.Core.Data.Model.Evaluation>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Evaluation, DTO.Evaluation>();
            Mapper.CreateMap<DTO.Evaluation, HCRGUniversity.Core.BL.Model.Evaluation>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.EvaluationQuestion, DTO.EvaluationQuestion>();
            Mapper.CreateMap<DTO.EvaluationQuestion, HCRGUniversity.Core.Data.Model.EvaluationQuestion>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.EducationEvaluation, DTO.EducationEvaluation>();
            Mapper.CreateMap<DTO.EducationEvaluation, HCRGUniversity.Core.Data.Model.EducationEvaluation>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.PreTestQuestionDetail, DTO.PreTestQuestionDetail>();
            Mapper.CreateMap<DTO.PreTestQuestionDetail, HCRGUniversity.Core.Data.Model.PreTestQuestionDetail>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.PreTestResult, DTO.PreTestResult>();
            Mapper.CreateMap<DTO.PreTestResult, HCRGUniversity.Core.Data.Model.PreTestResult>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.PreTestQuestionResult, DTO.PreTestQuestionResult>();
            Mapper.CreateMap<DTO.PreTestQuestionResult, HCRGUniversity.Core.Data.Model.PreTestQuestionResult>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.ExamResult, DTO.ExamResult>();
            Mapper.CreateMap<DTO.ExamResult, HCRGUniversity.Core.Data.Model.ExamResult>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.ExamQuestionResult, DTO.ExamQuestionResult>();
            Mapper.CreateMap<DTO.ExamQuestionResult, HCRGUniversity.Core.Data.Model.ExamQuestionResult>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.EvaluationResult, DTO.EvaluationResult>();
            Mapper.CreateMap<DTO.EvaluationResult, HCRGUniversity.Core.Data.Model.EvaluationResult>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.EvaluationQuestionResult, DTO.EvaluationQuestionResult>();
            Mapper.CreateMap<DTO.EvaluationQuestionResult, HCRGUniversity.Core.Data.Model.EvaluationQuestionResult>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.EvaluationAnswer, DTO.EvaluationAnswer>();
            Mapper.CreateMap<DTO.EvaluationAnswer, HCRGUniversity.Core.Data.Model.EvaluationAnswer>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.ExamQuestionDetail, DTO.ExamQuestionDetail>();
            Mapper.CreateMap<DTO.ExamQuestionDetail, HCRGUniversity.Core.Data.Model.ExamQuestionDetail>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.EvaluationQuestionDetail, DTO.EvaluationQuestionDetail>();
            Mapper.CreateMap<DTO.EvaluationQuestionDetail, HCRGUniversity.Core.Data.Model.EvaluationQuestionDetail>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.Faculty, DTO.Faculty>();
            Mapper.CreateMap<DTO.Faculty, HCRGUniversity.Core.Data.Model.Faculty>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Faculty, DTO.Faculty>();
            Mapper.CreateMap<DTO.Faculty, HCRGUniversity.Core.BL.Model.Faculty>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.HomeContent, DTO.HomeContent>();
            Mapper.CreateMap<DTO.HomeContent, HCRGUniversity.Core.Data.Model.HomeContent>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.HomeContent, DTO.HomeContent>();
            Mapper.CreateMap<DTO.HomeContent, HCRGUniversity.Core.BL.Model.HomeContent>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.Accreditor, DTO.Accreditor>();
            Mapper.CreateMap<DTO.Accreditor, HCRGUniversity.Core.Data.Model.Accreditor>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Accreditor, DTO.Accreditor>();
            Mapper.CreateMap<DTO.Accreditor, HCRGUniversity.Core.BL.Model.Accreditor>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.Certification, DTO.Certification>();
            Mapper.CreateMap<DTO.Certification, HCRGUniversity.Core.Data.Model.Certification>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Certification, DTO.Certification>();
            Mapper.CreateMap<DTO.Certification, HCRGUniversity.Core.BL.Model.Certification>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.EducationCredential, DTO.EducationCredential>();
            Mapper.CreateMap<DTO.EducationCredential, HCRGUniversity.Core.Data.Model.EducationCredential>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.EducationCredential, DTO.EducationCredential>();
            Mapper.CreateMap<DTO.EducationCredential, HCRGUniversity.Core.BL.Model.EducationCredential>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.Event, DTO.Event>();
            Mapper.CreateMap<DTO.Event, HCRGUniversity.Core.Data.Model.Event>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.EventDetail, DTO.Event>();
            Mapper.CreateMap<DTO.Event, HCRGUniversity.Core.Data.Model.EventDetail>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.CertificateDetail, DTO.CertificateDetail>();
            Mapper.CreateMap<DTO.CertificateDetail, HCRGUniversity.Core.Data.Model.CertificateDetail>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.IndustryResearch, DTO.IndustryResearch>();
            Mapper.CreateMap<DTO.IndustryResearch, HCRGUniversity.Core.Data.Model.IndustryResearch>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.IndustryResearch, DTO.IndustryResearch>();
            Mapper.CreateMap<DTO.IndustryResearch, HCRGUniversity.Core.BL.Model.IndustryResearch>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.MyEducationAccountHistory, DTO.MyEducationAccountHistory>();
            Mapper.CreateMap<DTO.MyEducationAccountHistory, HCRGUniversity.Core.Data.Model.MyEducationAccountHistory>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.EducationNewsSearch, DTO.EducationNewsSearch>();
            Mapper.CreateMap<DTO.EducationNewsSearch, HCRGUniversity.Core.Data.Model.EducationNewsSearch>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.CourseExpirySendEmail, DTO.CourseExpirySendEmail>();
            Mapper.CreateMap<DTO.CourseExpirySendEmail, HCRGUniversity.Core.Data.Model.CourseExpirySendEmail>();
            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.LogSession, DTO.LogSession>();
            Mapper.CreateMap<DTO.LogSession, HCRGUniversity.Core.Data.Model.LogSession>();
            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.LogSessionDetail, DTO.LogSessionDetail>();
            Mapper.CreateMap<DTO.LogSessionDetail, HCRGUniversity.Core.Data.Model.LogSessionDetail>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.TrainingAndSeminar, DTO.TrainingAndSeminar>();
            Mapper.CreateMap<DTO.TrainingAndSeminar, HCRGUniversity.Core.Data.Model.TrainingAndSeminar>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.TrainingAndSeminar, DTO.TrainingAndSeminar>();
            Mapper.CreateMap<DTO.TrainingAndSeminar, HCRGUniversity.Core.BL.Model.TrainingAndSeminar>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.Accreditation, DTO.Accreditation>();
            Mapper.CreateMap<DTO.Accreditation, HCRGUniversity.Core.Data.Model.Accreditation>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Accreditation, DTO.Accreditation>();
            Mapper.CreateMap<DTO.Accreditation, HCRGUniversity.Core.BL.Model.Accreditation>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.Product, DTO.Product>();
            Mapper.CreateMap<DTO.Product, HCRGUniversity.Core.Data.Model.Product>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.ProductQuantity, DTO.ProductQuantity>();
            Mapper.CreateMap<DTO.ProductQuantity, HCRGUniversity.Core.Data.Model.ProductQuantity>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.TermsCondition, DTO.TermsCondition>();
            Mapper.CreateMap<DTO.TermsCondition, HCRGUniversity.Core.Data.Model.TermsCondition>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.PrivacyPolicy, DTO.PrivacyPolicy>();
            Mapper.CreateMap<DTO.PrivacyPolicy, HCRGUniversity.Core.Data.Model.PrivacyPolicy>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.PrivacyPolicy, DTO.PrivacyPolicy>();
            Mapper.CreateMap<DTO.PrivacyPolicy, HCRGUniversity.Core.BL.Model.PrivacyPolicy>();

            #region Return Policy
            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.ReturnPolicy, DTO.ReturnPolicy>();
            Mapper.CreateMap<DTO.ReturnPolicy, HCRGUniversity.Core.Data.Model.ReturnPolicy>();
            #endregion

            #region Delivery Term
            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.DeliveryTerm, DTO.DeliveryTerm>();
            Mapper.CreateMap<DTO.DeliveryTerm, HCRGUniversity.Core.Data.Model.DeliveryTerm>();
            #endregion

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.NewsLetter, DTO.NewsLetter>();
            Mapper.CreateMap<DTO.NewsLetter, HCRGUniversity.Core.Data.Model.NewsLetter>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.NewsLetter, DTO.NewsLetter>();
            Mapper.CreateMap<DTO.NewsLetter, HCRGUniversity.Core.BL.Model.NewsLetter>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.ProductShopping, DTO.ProductShopping>();
            Mapper.CreateMap<DTO.ProductShopping, HCRGUniversity.Core.Data.Model.ProductShopping>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.ProductShoppingTemp, DTO.ProductShoppingTemp>();
            Mapper.CreateMap<DTO.ProductShoppingTemp, HCRGUniversity.Core.Data.Model.ProductShoppingTemp>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.ProductPurchase, DTO.ProductPurchase>();
            Mapper.CreateMap<DTO.ProductPurchase, HCRGUniversity.Core.BL.Model.ProductPurchase>();


            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.BillingAddress, DTO.BillingAddress>();
            Mapper.CreateMap<DTO.BillingAddress, HCRGUniversity.Core.Data.Model.BillingAddress>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.ShippingAddress, DTO.ShippingAddress>();
            Mapper.CreateMap<DTO.ShippingAddress, HCRGUniversity.Core.Data.Model.ShippingAddress>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.UserCardDetail, DTO.UserCardDetail>();
            Mapper.CreateMap<DTO.UserCardDetail, HCRGUniversity.Core.Data.Model.UserCardDetail>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.State, DTO.State>();
            Mapper.CreateMap<DTO.State, HCRGUniversity.Core.Data.Model.State>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.ShippingPayment, DTO.ShippingPayment>();
            Mapper.CreateMap<DTO.ShippingPayment, HCRGUniversity.Core.Data.Model.ShippingPayment>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.ShippingMethod, DTO.ShippingMethod>();
            Mapper.CreateMap<DTO.ShippingMethod, HCRGUniversity.Core.Data.Model.ShippingMethod>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.UserSubscription, DTO.UserSubscription>();
            Mapper.CreateMap<DTO.UserSubscription, HCRGUniversity.Core.Data.Model.UserSubscription>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.UserSubscription, DTO.UserSubscription>();
            Mapper.CreateMap<DTO.UserSubscription, HCRGUniversity.Core.BL.Model.UserSubscription>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.EnterprisePackageRegister, DTO.EnterprisePackageRegister>();
            Mapper.CreateMap<DTO.EnterprisePackageRegister, HCRGUniversity.Core.Data.Model.EnterprisePackageRegister>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.EnterprisePackageRegister, DTO.EnterprisePackageRegister>();
            Mapper.CreateMap<DTO.EnterprisePackageRegister, HCRGUniversity.Core.BL.Model.EnterprisePackageRegister>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.UserAllAccessPass, DTO.UserAllAccessPass>();
            Mapper.CreateMap<DTO.UserAllAccessPass, HCRGUniversity.Core.Data.Model.UserAllAccessPass>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.SuggestCourse, DTO.SuggestCourse>();
            Mapper.CreateMap<DTO.SuggestCourse, HCRGUniversity.Core.Data.Model.SuggestCourse>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.SuggestCourse, DTO.SuggestCourse>();
            Mapper.CreateMap<DTO.SuggestCourse, HCRGUniversity.Core.BL.Model.SuggestCourse>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.Enterprise, DTO.Enterprise>();
            Mapper.CreateMap<DTO.Enterprise, HCRGUniversity.Core.Data.Model.Enterprise>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.ProductShippingDetail, DTO.ProductShippingDetail>();
            Mapper.CreateMap<DTO.ProductShippingDetail, HCRGUniversity.Core.Data.Model.ProductShippingDetail>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.ProductShippingAddressDetailByID, DTO.ProductShippingAddressDetailByID>();
            Mapper.CreateMap<DTO.ProductShippingAddressDetailByID, HCRGUniversity.Core.BL.Model.ProductShippingAddressDetailByID>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.ProductPurchase, DTO.ProductPurchase>();
            Mapper.CreateMap<DTO.ProductPurchase, HCRGUniversity.Core.BL.Model.ProductPurchase>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.OrganizationContact, DTO.OrganizationContact>();
            Mapper.CreateMap<DTO.OrganizationContact, HCRGUniversity.Core.Data.Model.OrganizationContact>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.OrganizationContact, DTO.OrganizationContact>();
            Mapper.CreateMap<DTO.OrganizationContact, HCRGUniversity.Core.BL.Model.OrganizationContact>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.Client, DTO.Client>();
            Mapper.CreateMap<DTO.Client, HCRGUniversity.Core.Data.Model.Client>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.ClientType, DTO.ClientType>();
            Mapper.CreateMap<DTO.ClientType, HCRGUniversity.Core.Data.Model.ClientType>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.Organization, DTO.Organization>();
            Mapper.CreateMap<DTO.Organization, HCRGUniversity.Core.Data.Model.Organization>();

           
            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.Industry, DTO.Industry>();
            Mapper.CreateMap<DTO.Industry, HCRGUniversity.Core.Data.Model.Industry>();

           

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Client, DTO.Client>();
            Mapper.CreateMap<DTO.Client, HCRGUniversity.Core.BL.Model.Client>();

            //*************** Paged

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Paged.DiscountCoupan, DTO.Paged.PagedDiscountCoupon>();
            Mapper.CreateMap<DTO.Paged.PagedDiscountCoupon, HCRGUniversity.Core.BL.Model.Paged.DiscountCoupan>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Paged.College, DTO.Paged.PagedCollege>();
            Mapper.CreateMap<DTO.Paged.PagedCollege, HCRGUniversity.Core.BL.Model.Paged.College>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Paged.CertificationTitleOption, DTO.Paged.PagedCertificationTitleOption>();
            Mapper.CreateMap<DTO.Paged.PagedCertificationTitleOption, HCRGUniversity.Core.BL.Model.Paged.CertificationTitleOption>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Paged.Faculties, DTO.Paged.PagedFaculty>();
            Mapper.CreateMap<DTO.Paged.PagedFaculty, HCRGUniversity.Core.BL.Model.Paged.Faculties>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Paged.SuggestCourses, DTO.Paged.PagedSuggestCourse>();
            Mapper.CreateMap<DTO.Paged.PagedSuggestCourse, HCRGUniversity.Core.BL.Model.Paged.SuggestCourses>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Paged.EnterprisePackageRegisters, DTO.Paged.PagedEnterprisePackageRegister>();
            Mapper.CreateMap<DTO.Paged.PagedEnterprisePackageRegister, HCRGUniversity.Core.BL.Model.Paged.EnterprisePackageRegisters>();



            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Paged.AboutUs, DTO.Paged.PagedAboutUs>();
            Mapper.CreateMap<DTO.Paged.PagedAboutUs, HCRGUniversity.Core.BL.Model.Paged.AboutUs>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Paged.EducationFormat, DTO.Paged.PagedEducationFormat>();
            Mapper.CreateMap<DTO.Paged.PagedEducationFormat, HCRGUniversity.Core.BL.Model.Paged.EducationFormat>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Paged.Profession, DTO.Paged.PagedProfession>();
            Mapper.CreateMap<DTO.Paged.PagedProfession, HCRGUniversity.Core.BL.Model.Paged.Profession>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Paged.News, DTO.Paged.PagedNews>();
            Mapper.CreateMap<DTO.Paged.PagedNews, HCRGUniversity.Core.BL.Model.Paged.News>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Paged.NewsFullDetail, DTO.Paged.PagedNewsDetail>();
            Mapper.CreateMap<DTO.Paged.PagedNewsDetail, HCRGUniversity.Core.BL.Model.Paged.NewsFullDetail>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Paged.FAQ, DTO.Paged.PagedFAQ>();
            Mapper.CreateMap<DTO.Paged.PagedProfession, HCRGUniversity.Core.BL.Model.Paged.Profession>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Paged.EducationProfession, DTO.Paged.PagedEducationProfession>();
            Mapper.CreateMap<DTO.Paged.PagedEducationProfession, HCRGUniversity.Core.BL.Model.Paged.EducationProfession>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Paged.Education, DTO.Paged.PagedEducation>();
            Mapper.CreateMap<DTO.Paged.PagedEducation, HCRGUniversity.Core.BL.Model.Paged.Education>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Paged.User, DTO.Paged.PagedUser>();
            Mapper.CreateMap<DTO.Paged.PagedUser, HCRGUniversity.Core.BL.Model.Paged.User>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Paged.EducationModule, DTO.Paged.PagedEducationModule>();
            Mapper.CreateMap<DTO.Paged.PagedEducationModule, HCRGUniversity.Core.BL.Model.Paged.EducationModule>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Paged.ExamQuestion, DTO.Paged.PagedExamQuestion>();
            Mapper.CreateMap<DTO.Paged.PagedExamQuestion, HCRGUniversity.Core.BL.Model.Paged.ExamQuestion>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Paged.PreTestQuestion, DTO.Paged.PagedPreTestQuestion>();
            Mapper.CreateMap<DTO.Paged.PagedPreTestQuestion, HCRGUniversity.Core.BL.Model.Paged.PreTestQuestion>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Paged.Exam, DTO.Paged.PagedExam>();
            Mapper.CreateMap<DTO.Paged.PagedExam, HCRGUniversity.Core.BL.Model.Paged.Exam>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Paged.PreTest, DTO.Paged.PagedPreTest>();
            Mapper.CreateMap<DTO.Paged.PagedPreTest, HCRGUniversity.Core.BL.Model.Paged.PreTest>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Paged.Evaluation, DTO.Paged.PagedEvaluation>();
            Mapper.CreateMap<DTO.Paged.PagedEvaluation, HCRGUniversity.Core.BL.Model.Paged.Evaluation>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Paged.EvaluationQuestion, DTO.Paged.PagedEvaluationQuestion>();
            Mapper.CreateMap<DTO.Paged.PagedEvaluationQuestion, HCRGUniversity.Core.BL.Model.Paged.EvaluationQuestion>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Paged.Accreditor, DTO.Paged.PagedAccreditor>();
            Mapper.CreateMap<DTO.Paged.PagedAccreditor, HCRGUniversity.Core.BL.Model.Paged.Accreditor>();
            
            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Paged.MyEducation, DTO.Paged.PagedMyEducation>();
            Mapper.CreateMap<DTO.Paged.PagedMyEducation, HCRGUniversity.Core.BL.Model.Paged.MyEducation>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Paged.Events, DTO.Paged.PagedEvents>();
            Mapper.CreateMap<DTO.Paged.PagedEvents, HCRGUniversity.Core.BL.Model.Paged.Events>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Paged.MyEducationAccountHistory, DTO.Paged.PagedMyEducationAccountHistory>();
            Mapper.CreateMap<DTO.Paged.PagedMyEducationAccountHistory, HCRGUniversity.Core.BL.Model.Paged.MyEducationAccountHistory>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Paged.EducationNewsSearch, DTO.Paged.PagedEducationNewsSearch>();
            Mapper.CreateMap<DTO.Paged.PagedEducationNewsSearch, HCRGUniversity.Core.BL.Model.Paged.EducationNewsSearch>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Paged.LogSessionDetail, DTO.Paged.PagedLogSessionDetail>();
            Mapper.CreateMap<DTO.Paged.PagedLogSessionDetail, HCRGUniversity.Core.BL.Model.Paged.LogSessionDetail>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Paged.Product, DTO.Paged.PagedProduct>();
            Mapper.CreateMap<DTO.Paged.PagedProduct, HCRGUniversity.Core.BL.Model.Paged.Product>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Paged.ProductQuantityDetail, DTO.Paged.PagedProductQuantity>();
            Mapper.CreateMap<DTO.Paged.PagedProductQuantity, HCRGUniversity.Core.BL.Model.Paged.ProductQuantityDetail>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Paged.ProductPurchaseDetail, DTO.Paged.PagedProductPurchase>();
            Mapper.CreateMap< DTO.Paged.PagedProductPurchase,HCRGUniversity.Core.BL.Model.Paged.ProductPurchaseDetail>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Paged.BillingAddress , DTO.Paged.PagedBillingAddress>();
            Mapper.CreateMap<DTO.Paged.PagedBillingAddress, HCRGUniversity.Core.BL.Model.Paged.BillingAddress>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Paged.ShippingAddress, DTO.Paged.PagedShippingAddress>();
            Mapper.CreateMap<DTO.Paged.PagedShippingAddress, HCRGUniversity.Core.BL.Model.Paged.ShippingAddress>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Paged.UserCardDetail, DTO.Paged.PagedUserCardDetail>();
            Mapper.CreateMap<DTO.Paged.PagedUserCardDetail, HCRGUniversity.Core.BL.Model.Paged.UserCardDetail>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Paged.ShippingPayment, DTO.Paged.PagedShippingPayment>();
            Mapper.CreateMap<DTO.Paged.PagedShippingPayment, HCRGUniversity.Core.BL.Model.Paged.ShippingPayment>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Paged.EnterpriseDetail, DTO.Paged.PagedEnterpriseDetail>();
            Mapper.CreateMap<DTO.Paged.PagedEnterpriseDetail, HCRGUniversity.Core.BL.Model.Paged.EnterpriseDetail>();


            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Paged.ProductShippingDetail, DTO.Paged.PagedProductShippingDetail>();
            Mapper.CreateMap<DTO.Paged.PagedProductShippingDetail, HCRGUniversity.Core.BL.Model.Paged.ProductShippingDetail>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Paged.ProductPurchasesRecord, DTO.Paged.PagedProductPurchasesRecord>();
            Mapper.CreateMap<DTO.Paged.PagedProductPurchasesRecord, HCRGUniversity.Core.BL.Model.Paged.ProductPurchasesRecord>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Paged.Client, DTO.Paged.PagedClient>();
            Mapper.CreateMap<DTO.Paged.PagedClient, HCRGUniversity.Core.BL.Model.Paged.Client>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.Plan, DTO.Plan>();
            Mapper.CreateMap<DTO.Plan, HCRGUniversity.Core.Data.Model.Plan>();
            
            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Plan, DTO.Plan>();
            Mapper.CreateMap<DTO.Plan, HCRGUniversity.Core.BL.Model.Plan>();


            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.UserPlan, DTO.UserPlan>();
            Mapper.CreateMap<DTO.UserPlan, HCRGUniversity.Core.BL.Model.UserPlan>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.UserPlan, DTO.UserPlan>();
            Mapper.CreateMap<DTO.UserPlan, HCRGUniversity.Core.Data.Model.UserPlan>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.CoursePlan, DTO.CoursePlan>();
            Mapper.CreateMap<DTO.CoursePlan, HCRGUniversity.Core.BL.Model.CoursePlan>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Paged.Plan, DTO.Paged.PagedPlan>();
            Mapper.CreateMap<DTO.Paged.PagedPlan, HCRGUniversity.Core.BL.Model.Paged.Plan>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.Menu, DTO.Menu>();
            Mapper.CreateMap<DTO.Menu, HCRGUniversity.Core.Data.Model.Menu>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.UserMenuGroup, DTO.UserMenuGroup>();
            Mapper.CreateMap<DTO.UserMenuGroup, HCRGUniversity.Core.Data.Model.UserMenuGroup>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Paged.UserMenuGroup, DTO.Paged.PagedUserMenuGroup>();
            Mapper.CreateMap<DTO.Paged.PagedUserMenuGroup, HCRGUniversity.Core.BL.Model.Paged.UserMenuGroup>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.UserMenuPermission, DTO.UserMenuPermission>();
            Mapper.CreateMap<DTO.UserMenuPermission, HCRGUniversity.Core.Data.Model.UserMenuPermission>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.PlanPackages, DTO.PlanPackages>();
            Mapper.CreateMap<DTO.PlanPackages, HCRGUniversity.Core.BL.Model.PlanPackages>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.UserMenuGroupAndPermission, DTO.UserMenuGroupAndPermission>();
            Mapper.CreateMap<DTO.UserMenuGroupAndPermission, HCRGUniversity.Core.Data.Model.UserMenuGroupAndPermission>();

            Mapper.CreateMap<HCRGUniversity.Core.Data.Model.ClientAndUserbySearchCriterias, DTO.ClientAndUserbySearchCriterias>();
            Mapper.CreateMap<DTO.ClientAndUserbySearchCriterias, HCRGUniversity.Core.Data.Model.ClientAndUserbySearchCriterias>();


            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.PlanGrid, DTO.PlanGrid>();
            Mapper.CreateMap<DTO.PlanGrid, HCRGUniversity.Core.BL.Model.PlanGrid>();

            Mapper.CreateMap<HCRGUniversity.Core.BL.Model.Paged.PlanGrid, DTO.Paged.PagedPlanGrid>();
            Mapper.CreateMap<DTO.Paged.PagedPlanGrid, HCRGUniversity.Core.BL.Model.Paged.PlanGrid>();

        }
    }
}