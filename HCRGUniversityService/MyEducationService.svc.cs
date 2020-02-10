using System.Collections.Generic;
using AutoMapper;
using System.ServiceModel;
using HCRGUniversityService.Contracts;
using HCRGUniversityService.CustomServiceBehaviors;
using HCRGUniversity.Core.BL;

namespace HCRGUniversityService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    [AutoMapperServiceBehavior]
    public class MyEducationService : IMyEducationService
    {
        private readonly IMyEducation _myEducation;

        public MyEducationService(IMyEducation myEducation)
        {
            _myEducation = myEducation;
        }

        public DTO.Paged.PagedMyEducation GetMyEducationCompletedByUserIDPaged(int userID, int skip, int take)
        {
            return Mapper.Map<DTO.Paged.PagedMyEducation>(_myEducation.GetMyEducationCompletedByUserIDPaged(userID, skip, take));
        }

        public DTO.Paged.PagedMyEducation GetMyEducationInProgressByUserIDPaged(int userID, int skip, int take)
        {
            return Mapper.Map<DTO.Paged.PagedMyEducation>(_myEducation.GetMyEducationInProgressByUserIDPaged(userID, skip, take));
        }

        public DTO.Paged.PagedMyEducationAccountHistory GetMyEducationDetailByUserIDPaged(int userID, int skip, int take)
        {
            return Mapper.Map<DTO.Paged.PagedMyEducationAccountHistory>(_myEducation.GetMyEducationDetailByUserIDPaged(userID, skip, take));
        }

        public IEnumerable<DTO.MyEducationModuleDetail> GetMyEducationModulesDetailsByMEID(int meID, int userID)
        {
            return Mapper.Map<IEnumerable<DTO.MyEducationModuleDetail>>(_myEducation.GetMyEducationModulesDetailsByMEID(meID, userID));
        }

        public DTO.MyEducationModuleDetail GetMyEducationModulesDetailByMEMID(int memID)
        {
            return Mapper.Map<DTO.MyEducationModuleDetail>(_myEducation.GetMyEducationModulesDetailByMEMID(memID));
        }
        public int UpdateMyEducationModule(DTO.MyEducationModule myEducationModule)
        {
            return _myEducation.UpdateMyEducationModule(Mapper.Map<HCRGUniversity.Core.Data.Model.MyEducationModule>(myEducationModule));
        }
        
        public void UpdateMyEducationModuleTimeLeft(int memID, string TimeLeft)
        {
            _myEducation.UpdateMyEducationModuleTimeLeft(memID, TimeLeft);
        }
        public void UpdateMyEducationExpiredByUserID(int userID)
        {
            _myEducation.UpdateMyEducationExpiredByUserID(userID);
        }

        public void UpdateMyEducationCourseCompletedByMEMID(int memID,int meID)
        {
            _myEducation.UpdateMyEducationCourseCompletedByMEMID(memID, meID);
        }

        public void UpdateMyEducationForCertificateByMEID(int meid, bool isPrinted, string certificateName)
        {
            _myEducation.UpdateMyEducationForCertificateByMEID(meid, isPrinted, certificateName);
        }

        public DTO.CertificateDetail GetCertificateDetailByMEID(int meID)
        {
            return Mapper.Map<DTO.CertificateDetail>(_myEducation.GetCertificateDetailByMEID(meID));
        }

        public int GetMyEducationByID(int meID)
        {
            return _myEducation.GetMyEducationByID(meID);
        }

    
    }
}
