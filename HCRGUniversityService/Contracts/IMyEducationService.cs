using System.ServiceModel;
using System.Collections.Generic;
using HCRGUniversityService.DTO;

namespace HCRGUniversityService.Contracts
{
    [ServiceContract]
    public interface IMyEducationService
    {
        [OperationContract]
        DTO.Paged.PagedMyEducation GetMyEducationCompletedByUserIDPaged(int userID, int skip, int take);

        [OperationContract]
        DTO.Paged.PagedMyEducation GetMyEducationInProgressByUserIDPaged(int userID, int skip, int take);

        [OperationContract]
        DTO.Paged.PagedMyEducationAccountHistory GetMyEducationDetailByUserIDPaged(int userID, int skip, int take);

        [OperationContract]
        IEnumerable<MyEducationModuleDetail> GetMyEducationModulesDetailsByMEID(int meID, int userID);

        [OperationContract]
        MyEducationModuleDetail GetMyEducationModulesDetailByMEMID(int memID);

        [OperationContract]
        int UpdateMyEducationModule(MyEducationModule myEducationModule);

        [OperationContract]
        void UpdateMyEducationModuleTimeLeft(int memID, string TimeLeft);

        [OperationContract]
        void UpdateMyEducationExpiredByUserID(int userID);

        [OperationContract]
        void UpdateMyEducationCourseCompletedByMEMID(int memID, int meID);

        [OperationContract]
        void UpdateMyEducationForCertificateByMEID(int meid, bool isPrinted, string certificateName);

        [OperationContract]
        CertificateDetail GetCertificateDetailByMEID(int meID);

        [OperationContract]
        int GetMyEducationByID(int meID);
    }
}
