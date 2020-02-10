using System.ServiceModel;
using HCRGUniversityService.DTO;
using System.Collections.Generic;
using HCRGUniversityService.DTO.Paged;
namespace HCRGUniversityService.Contracts
{
    [ServiceContract]
    public interface ILogSessionService
    {
        [OperationContract]
        int AddSession(LogSession logSession);
        [OperationContract]
        void LogModuleOrExam(string browser, string newurl, int MEID, int UserId);
        [OperationContract]
        bool CheckLogModuleOrExam(int MEID, int UserId);
        [OperationContract]
        void DeleteSession(string browser, int MEID, int UserID);
        [OperationContract]
        LogSession getLogSessionByUserIDAndMEID(int UserId, int MEID);
        [OperationContract]
        void DeleteSessionAfterSchedule(int UserID, int LogScheduleTime);
        [OperationContract]
        PagedLogSessionDetail getAllLogSession(int skip, int take);
        [OperationContract]
        PagedLogSessionDetail GetLogSessionByUserName(string username, int skip, int take, int organizationId);
        [OperationContract]
        void DeleteSessionByAdmin(int LogSessionID);
    }
}
