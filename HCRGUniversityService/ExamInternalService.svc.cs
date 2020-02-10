using HCRGUniversity.Core.BL;
using HCRGUniversityService.CustomServiceBehaviors;
using HCRGUniversityService.DTO.Paged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using HCRGUniversityService.Contracts;
using AutoMapper;
using HCRGUniversity.Core.Data.Model;

namespace HCRGUniversityService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    [AutoMapperServiceBehavior]
    public class ExamInternalService : IExamInternalService
    {
        private readonly IExamInternal _examInternal;
        public ExamInternalService(IExamInternal examInternal)
        {
            _examInternal = examInternal;
        }
        public int AddPreTestResult(DTO.PreTestResult preTestResult)
        {
            return _examInternal.AddPreTestResult(Mapper.Map<DTO.PreTestResult, PreTestResult>(preTestResult));
        }

        public int UpdatePreTestResult(DTO.PreTestResult preTestResult)
        {
            return _examInternal.UpdatePreTestResult(Mapper.Map<DTO.PreTestResult, PreTestResult>(preTestResult));
        }

        public void UpdatePreTestResultIsPass(int preTestResultID, bool isPass)
        {
            _examInternal.UpdatePreTestResultIsPass(preTestResultID, isPass);
        }

        public int GetPreTestAttemptByUser(int userID,int MEID)
        {
            return _examInternal.GetPreTestAttemptByUser(userID, MEID);
        }

        public int AddPreTestQuestionResults(DTO.PreTestQuestionResult preTestQuestionResult)
        {
            return _examInternal.AddPreTestQuestionResults(Mapper.Map<DTO.PreTestQuestionResult, PreTestQuestionResult>(preTestQuestionResult));
        }

        public int UpdatePreTestQuestionResult(DTO.PreTestQuestionResult preTestQuestionResult)
        {
            return _examInternal.UpdatePreTestQuestionResult(Mapper.Map<DTO.PreTestQuestionResult, PreTestQuestionResult>(preTestQuestionResult));
        }

        //exam Results...hp
        public int AddExamResult(DTO.ExamResult examResult)
        {
            return _examInternal.AddExamResult(Mapper.Map<DTO.ExamResult, ExamResult>(examResult));
        }

        public int UpdateExamResult(DTO.ExamResult examResult)
        {
            return _examInternal.UpdateExamResult(Mapper.Map<DTO.ExamResult, ExamResult>(examResult));
        }
        public void UpdateExamResultIsPass(int examResultID,int MEID, bool isPass)
        {
            _examInternal.UpdateExamResultIsPass(examResultID, MEID, isPass);
        }

        public IEnumerable<DTO.ExamResult> GetExamAttempResulttByUser(int userID, int MEID)
        {
            return Mapper.Map<IEnumerable<DTO.ExamResult>>(_examInternal.GetExamAttempResulttByUser(userID, MEID));
        }

        public int AddExamQuestionResults(DTO.ExamQuestionResult examQuestionResult)
        {
            return _examInternal.AddExamQuestionResults(Mapper.Map<DTO.ExamQuestionResult, ExamQuestionResult>(examQuestionResult));
        }

        public int UpdateExamQuestionResult(DTO.ExamQuestionResult examQuestionResult)
        {
            return _examInternal.UpdateExamQuestionResult(Mapper.Map<DTO.ExamQuestionResult, ExamQuestionResult>(examQuestionResult));
        }


        //Evaluation Results...
        public int AddEvaluationResult(DTO.EvaluationResult evaluationResult)
        {
            return _examInternal.AddEvaluationResult(Mapper.Map<DTO.EvaluationResult, EvaluationResult>(evaluationResult));
        }

        public int UpdateEvaluationResult(DTO.EvaluationResult evaluationResult)
        {
            return _examInternal.UpdateEvaluationResult(Mapper.Map<DTO.EvaluationResult, EvaluationResult>(evaluationResult));
        }
        public void UpdateEvaluationResultIsPass(int evaluationResultID, bool isPass)
        {
            _examInternal.UpdateEvaluationResultIsPass(evaluationResultID, isPass);
        }

        public int GetEvaluationAttemptByUser(int userID)
        {
            return _examInternal.GetEvaluationAttemptByUser(userID);
        }

        public DTO.EvaluationResult GetEvaluationAttemptByUserAndMEID(int userID, int MEID)
        {
            return Mapper.Map<DTO.EvaluationResult>(_examInternal.GetEvaluationAttemptByUserAndMEID(userID, MEID));
        }


        public int AddEvaluationQuestionResults(DTO.EvaluationQuestionResult evaluationQuestionResult)
        {
            return _examInternal.AddEvaluationQuestionResults(Mapper.Map<DTO.EvaluationQuestionResult, EvaluationQuestionResult>(evaluationQuestionResult));
        }

        public int UpdateEvaluationQuestionResult(DTO.EvaluationQuestionResult evaluationQuestionResult)
        {
            return _examInternal.UpdateEvaluationQuestionResult(Mapper.Map<DTO.EvaluationQuestionResult, EvaluationQuestionResult>(evaluationQuestionResult));
        }

        public IEnumerable<DTO.EvaluationAnswer> GetAllEvaluationAnswer()
        {
            return Mapper.Map<IEnumerable<DTO.EvaluationAnswer>>(_examInternal.GetAllEvaluationAnswer());
        }     
    }
}