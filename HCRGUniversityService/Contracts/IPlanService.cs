using System.ServiceModel;
using HCRGUniversityService.DTO;
using System.Collections.Generic;
using HCRGUniversityService.DTO.Paged;


namespace HCRGUniversityService.Contracts
{
    [ServiceContract]
    public interface IPlanService
    {
        #region Plan
        [OperationContract]
        int AddPlan(Plan plan);

        [OperationContract]
        int UpdatePlan(Plan plan);

        [OperationContract]
        void DeletePlan(int planID);

        [OperationContract]
        DTO.Plan GetPlanById(int _planID);

        [OperationContract]
        IEnumerable<Plan> getAllRecords();

        [OperationContract]
        DTO.Paged.PagedPlanGrid GetAllPagedPlanByClientID(int clientID, int orgID, int skip, int take);

        [OperationContract]
        IEnumerable<PlanPackages> GetAllPlanAccToPackages();

        [OperationContract]
        IEnumerable<Plan> GetAllPlansByClientID(int ClientID);

        #endregion

        #region UserPlan
        [OperationContract]
        int AddUserPlan(DTO.UserPlan userPlan);
        [OperationContract]
        void DeleteUserPlan(int userPlanID);
        [OperationContract]
        IEnumerable<PlanPackages> GetUsersPlanAccToPlanID(int PlanID);
        [OperationContract]
        IEnumerable<PlanPackages> GetAllUsersPlan();
        [OperationContract]
        int AddMyEducationRecordByPlanID(int _planID);

        #endregion

        #region CoursePlan
        [OperationContract]
        int AddCoursePlan(DTO.CoursePlan coursePlan);
        [OperationContract]
        void DeleteCoursePlan(int coursePlanID);
        [OperationContract]
        IEnumerable<PlanPackages> GetCoursesPlanAccToPlanID(int PlanID);
        [OperationContract]
        IEnumerable<PlanPackages> GetAllCoursesPlan();
        #endregion
    }
}