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
    public class LogSessionService : ILogSessionService
    {
        private readonly ILogSession _logSession;
        public LogSessionService(ILogSession logSession)
        {
            _logSession = logSession;
        }

        public int AddSession(DTO.LogSession logSession)
        {
            return _logSession.AddSession(Mapper.Map<DTO.LogSession, HCRGUniversity.Core.Data.Model.LogSession>(logSession));
        }
        public void LogModuleOrExam(string browser, string newurl, int MEID, int UserId)
        {
            _logSession.LogModuleOrExam(browser, newurl, MEID, UserId);
        }
        public bool CheckLogModuleOrExam(int MEID, int UserId)
        {

            return (_logSession.CheckLogModuleOrExam(MEID,UserId));
        }
        public void DeleteSession(string browser, int MEID, int UserID)
        {
            _logSession.DeleteSession(browser, MEID, UserID);
        }
        public LogSession getLogSessionByUserIDAndMEID(int UserId, int MEID)
        {
            return Mapper.Map <LogSession>(_logSession.getLogSessionByUserIDAndMEID(UserId, MEID));
           
        }
        public void DeleteSessionAfterSchedule(int UserID, int LogScheduleTime)
        {
            _logSession.DeleteSessionAfterSchedule(UserID, LogScheduleTime);
        }
        public void DeleteSessionByAdmin(int LogSessionID)
        {
            _logSession.DeleteSessionByAdmin(LogSessionID);
        }
        public DTO.Paged.PagedLogSessionDetail getAllLogSession(int skip, int take)
        {
            return Mapper.Map<HCRGUniversity.Core.BL.Model.Paged.LogSessionDetail, DTO.Paged.PagedLogSessionDetail>(_logSession.getAllLogSession(skip, take));
        }
        public DTO.Paged.PagedLogSessionDetail GetLogSessionByUserName(string username, int skip, int take, int organizationId)
        {
            return Mapper.Map<HCRGUniversity.Core.BL.Model.Paged.LogSessionDetail, DTO.Paged.PagedLogSessionDetail>(_logSession.GetLogSessionByUserName(username, skip, take, organizationId));
        }

    }
}
