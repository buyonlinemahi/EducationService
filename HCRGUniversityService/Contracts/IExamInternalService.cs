using System.ServiceModel;
using HCRGUniversityService.DTO;
using System.Collections.Generic;

namespace HCRGUniversityService.Contracts
{
    [ServiceContract]
    public interface IExamInternalService
    {
        //pretest, exam and evaluation at internal portal...hp
        //pre-test..hp
        [OperationContract]
        int AddPreTestResult(PreTestResult preTestResult);
        [OperationContract]
        int UpdatePreTestResult(PreTestResult preTestResult);
        [OperationContract]
        void UpdatePreTestResultIsPass(int preTestResultID, bool isPass);
        [OperationContract]
        int GetPreTestAttemptByUser(int userID,int MEID);

        [OperationContract]
        int AddPreTestQuestionResults(PreTestQuestionResult preTestQuestionResult);
        [OperationContract]
        int UpdatePreTestQuestionResult(PreTestQuestionResult preTestQuestionResult);

        //exam Results...hp
        [OperationContract]
        int AddExamResult(ExamResult examResult);
        [OperationContract]
        int UpdateExamResult(ExamResult examResult);
        [OperationContract]
        void UpdateExamResultIsPass(int examResultID,int MEID, bool isPass);
        [OperationContract]
        IEnumerable<ExamResult> GetExamAttempResulttByUser(int userID, int MEID);

        [OperationContract]
        int AddExamQuestionResults(ExamQuestionResult examQuestionResult);
        [OperationContract]
        int UpdateExamQuestionResult(ExamQuestionResult examQuestionResult);

        //evaluation Results...
          [OperationContract]
        int AddEvaluationResult(EvaluationResult evaluationResult);
          [OperationContract]
        int UpdateEvaluationResult(EvaluationResult examResult);
          [OperationContract]
        void UpdateEvaluationResultIsPass(int evaluationResultID, bool isPass);
          [OperationContract]
        int GetEvaluationAttemptByUser(int userID);

          [OperationContract]
          DTO.EvaluationResult GetEvaluationAttemptByUserAndMEID(int userID, int MEID);

          [OperationContract]
        int AddEvaluationQuestionResults(EvaluationQuestionResult evaluationQuestionResult);
          [OperationContract]
        int UpdateEvaluationQuestionResult(EvaluationQuestionResult evaluationQuestionResult);
          [OperationContract]
        IEnumerable<EvaluationAnswer> GetAllEvaluationAnswer();
    }
}
