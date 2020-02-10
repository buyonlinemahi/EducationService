using System.ServiceModel;
using HCRGUniversityService.DTO;
using System.Collections.Generic;
using HCRGUniversityService.DTO.Paged;

namespace HCRGUniversityService.Contracts
{
    [ServiceContract]
    public interface IExamQuestionService
    {
        [OperationContract]
        int AddExamQuestion(ExamQuestion examQuestion);
        [OperationContract]
        int UpdateExamQuestion(ExamQuestion examQuestion);
        [OperationContract]
        void DeleteExamQuestion(int examQuestionID);
        [OperationContract]
        ExamQuestion GetExamQuestionByID(int examQuestionID);
        [OperationContract]
        PagedExamQuestion GetAllPagedExamQuestionByExamID(int examID, int skip, int take);
        [OperationContract]
        IEnumerable<ExamQuestionDetail> GetAllExamQuestionDetailByEID(int educationID);
        [OperationContract]
        IEnumerable<ExamQuestion> GetExamQuestionWrongAnswered(int meID);

        //Pre Test Question
        [OperationContract]
        int AddPreTestQuestion(PreTestQuestion preTestQuestion);
        [OperationContract]
        int UpdatePreTestQuestion(PreTestQuestion preTestQuestion);
        [OperationContract]
        void DeletePreTestQuestion(int preTestQuestionID);
        [OperationContract]
        PreTestQuestion GetPreTestQuestionByID(int preTestQuestionID);
        [OperationContract]
        PagedPreTestQuestion GetAllPagedPreTestQuestionByPreTestID(int preTestID, int skip, int take);
        [OperationContract]
        IEnumerable<PreTestQuestionDetail> GetAllPreTestQuestionDetailByEID(int educationID);

        //EducationExamQuestions
        [OperationContract]
        int AddEducationExamQuestion(EducationExamQuestion educationExamQuestion);
        [OperationContract]
        void UpdateEducationExamQuestion(EducationExamQuestion educationExamQuestion);
        [OperationContract]
        void DeleteEducationExamQuestion(int courseExamQuestionID);
        [OperationContract]
        EducationExamQuestion GetEducationExamQuestionByEducationID(int educationID);
        //EducationPreTestQuestion
        [OperationContract]
        int AddEducationPreTestQuestion(EducationPreTestQuestion educationPreTestQuestions);
        [OperationContract]
        void UpdateEducationPreTestQuestion(EducationPreTestQuestion educationPreTestQuestions);
        [OperationContract]
        void DeleteEducationPreTestQuestion(int coursePreTestQuestionID);
        [OperationContract]
        EducationPreTestQuestion GetEducationPreTestQuestionByEducationID(int educationID);

        //Exam
        [OperationContract]
        int AddExam(Exam exam);
        [OperationContract]
        int UpdateExam(Exam exam);
        [OperationContract]
        void DeleteExam(int examID);
        [OperationContract]
        Exam GetExamByID(int examID);
        [OperationContract]
        PagedExam GetAllPagedExam(string name, int skip, int take, int ClientID,int orgID);
        [OperationContract]
        IEnumerable<Exam> GetAllActiveExam(int clientID);
        //Pre Test 
        [OperationContract]
        int AddPreTest(PreTest preTest);
        [OperationContract]
        int UpdatePreTest(PreTest preTest);
        [OperationContract]
        void DeletePreTest(int preTestID);
        [OperationContract]
        PreTest GetPreTestByID(int preTestID);
        [OperationContract]
        PagedPreTest GetAllPagedPreTest(string name, int skip, int take, int ClientID,int orgID);
        [OperationContract]
        IEnumerable<PreTest> GetAllActivePreTest(int clientID);
        //Evalution
        [OperationContract]
        int AddEvaluation(Evaluation Evaluation);
        [OperationContract]
        int UpdateEvaluation(Evaluation Evaluation);
        [OperationContract]
        int UpdateEvaluationStatus(Evaluation Evaluation);
        [OperationContract]
        void DeleteEvaluation(int EvaluationID);
        [OperationContract]
        Evaluation GetEvaluationByID(int EvaluationID);
        [OperationContract]
        PagedEvaluation GetAllPagedEvaluation(string name, int skip, int take, int ClientID,int orgID);
        [OperationContract]
        IEnumerable<Evaluation> GetAllActiveEvaluation(int clientID);

        [OperationContract]
        int AddEvaluationQuestion(EvaluationQuestion EvaluationQuestion);
        [OperationContract]
        int AddEvaluationQuestionsFromEvaluationPredefinedQuestions(int EvaluationID);
        [OperationContract]
        int UpdateEvaluationQuestion(EvaluationQuestion EvaluationQuestion);
        [OperationContract]
        int UpdateEvaluationQuestionStatus(EvaluationQuestion EvaluationQuestion);
        [OperationContract]
        void DeleteEvaluationQuestion(int EvaluationQuestionID);
        [OperationContract]
        EvaluationQuestion GetEvaluationQuestionByID(int EvaluationQuestionID);
        [OperationContract]
        PagedEvaluationQuestion GetAllPagedEvaluationQuestionByEvaluationID(int EvaluationID, int skip, int take);
        [OperationContract]
        IEnumerable<EvaluationQuestionDetail> GetAllEvaluationQuestionDetailByEID(int educationID);
        //EducationEvaluation
        [OperationContract]
        int AddEducationEvaluation(EducationEvaluation educationEvaluation);
        [OperationContract]
        void UpdateEducationEvaluation(EducationEvaluation educationEvaluation);
        [OperationContract]
        void DeleteEducationEvaluation(int courseEvaluationID);
        [OperationContract]
        EducationEvaluation GetEducationEvaluationByEducationID(int educationID);
    }
}