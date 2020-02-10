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
    public class PlanService : IPlanService
    {
        private readonly IPlan _plan;
        public PlanService(IPlan plan)
        {
            _plan = plan;
        }
        #region Plan
        public int AddPlan(Plan plan)
        {
            return _plan.AddPlan(Mapper.Map<DTO.Plan, HCRGUniversity.Core.BL.Model.Plan>(plan));
        }

        public int UpdatePlan(DTO.Plan plan)
        {
            return _plan.UpdatePlan(Mapper.Map<DTO.Plan, HCRGUniversity.Core.BL.Model.Plan>(plan));
        }

        public void DeletePlan(int planID)
        {
            _plan.DeletePlan(planID);
        }

        public DTO.Plan GetPlanById(int _planID)
        {
            return Mapper.Map<Plan>(_plan.GetPlanById(_planID));
        }

        public IEnumerable<Plan> getAllRecords()
        {
            return Mapper.Map<IEnumerable<Plan>>(_plan.getAll());
        }

        public DTO.Paged.PagedPlanGrid GetAllPagedPlanByClientID(int clientID, int orgID, int skip, int take)
        {
            return Mapper.Map<DTO.Paged.PagedPlanGrid>(_plan.GetAllPagedPlanByClientID(clientID,orgID,skip,take));
        }

        public IEnumerable<PlanPackages> GetAllPlanAccToPackages()
        {
            return Mapper.Map<IEnumerable<PlanPackages>>(_plan.GetAllPlanAccToPackages());
        }

        public IEnumerable<Plan> GetAllPlansByClientID(int ClientID)
        {
            return Mapper.Map<IEnumerable<DTO.Plan>>(_plan.GetAllPlansByClientID(ClientID));
        }

        #endregion

        #region UserPlan
        public int AddUserPlan(DTO.UserPlan userPlan)
        {
            return _plan.AddUserPlan(Mapper.Map<DTO.UserPlan, HCRGUniversity.Core.Data.Model.UserPlan>(userPlan));
        }
        public void DeleteUserPlan(int userPlanID)
        {
            _plan.DeleteUserPlan(userPlanID);
        }
        public IEnumerable<PlanPackages> GetUsersPlanAccToPlanID(int PlanID)
        {
            return Mapper.Map<IEnumerable<PlanPackages>>(_plan.GetUsersPlanAccToPlanID(PlanID));
        }
        public IEnumerable<PlanPackages> GetAllUsersPlan()
        {
            return Mapper.Map<IEnumerable<PlanPackages>>(_plan.GetAllUsersPlan());
        }
        public int AddMyEducationRecordByPlanID(int _planID)
        {
            return _plan.AddMyEducationRecordByPlanID(_planID);
        }


        #endregion

        #region CoursePlan
        public int AddCoursePlan(DTO.CoursePlan coursePlan)
        {
            return _plan.AddCoursePlan(Mapper.Map<DTO.CoursePlan, HCRGUniversity.Core.BL.Model.CoursePlan>(coursePlan));
        }
        public void DeleteCoursePlan(int coursePlanID)
        {
            _plan.DeleteCoursePlan(coursePlanID); 

        }
        public IEnumerable<PlanPackages> GetCoursesPlanAccToPlanID(int PlanID)
        {
            return Mapper.Map<IEnumerable<PlanPackages>>(_plan.GetCoursesPlanAccToPlanID(PlanID));
        }
        public IEnumerable<PlanPackages> GetAllCoursesPlan()
        {
            return Mapper.Map<IEnumerable<PlanPackages>>(_plan.GetAllCoursesPlan());
        }
        #endregion
    }
}
