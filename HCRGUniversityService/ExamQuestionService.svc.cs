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
    public class ExamQuestionService : IExamQuestionService
    {
        private readonly IExamQuestion _examQuestion;
        public ExamQuestionService(IExamQuestion examQuestion)
        {
            _examQuestion = examQuestion;

        }

        public int AddExamQuestion(DTO.ExamQuestion examQuestion)
        {
            return _examQuestion.AddExamQuestion(Mapper.Map<DTO.ExamQuestion, HCRGUniversity.Core.Data.Model.ExamQuestion>(examQuestion));
        }

        public int UpdateExamQuestion(DTO.ExamQuestion examQuestion)
        {
            return _examQuestion.UpdateExamQuestion(Mapper.Map<DTO.ExamQuestion, HCRGUniversity.Core.Data.Model.ExamQuestion>(examQuestion));
        }

        public void DeleteExamQuestion(int examQuestionID)
        {
            _examQuestion.DeleteExamQuestion(examQuestionID);
        }

        public DTO.ExamQuestion GetExamQuestionByID(int examQuestionID)
        {
            return Mapper.Map<DTO.ExamQuestion>(_examQuestion.GetExamQuestionByID(examQuestionID));
        }

        public DTO.Paged.PagedExamQuestion GetAllPagedExamQuestionByExamID(int examID, int skip, int take)
        {
            return Mapper.Map<DTO.Paged.PagedExamQuestion>(_examQuestion.GetAllPagedExamQuestionByExamID(examID,skip, take));
        }

        public IEnumerable<DTO.ExamQuestion> GetExamQuestionWrongAnswered(int meID)
        {
            return Mapper.Map<IEnumerable<DTO.ExamQuestion>>(_examQuestion.GetExamQuestionWrongAnswered(meID));
        }


        public int AddPreTestQuestion(DTO.PreTestQuestion preTestQuestion)
        {
            return _examQuestion.AddPreTestQuestion(Mapper.Map<DTO.PreTestQuestion, HCRGUniversity.Core.Data.Model.PreTestQuestion>(preTestQuestion));
        }

        public int UpdatePreTestQuestion(DTO.PreTestQuestion preTestQuestion)
        {
            return _examQuestion.UpdatePreTestQuestion(Mapper.Map<DTO.PreTestQuestion, HCRGUniversity.Core.Data.Model.PreTestQuestion>(preTestQuestion));
        }

        public void DeletePreTestQuestion(int preTestQuestionID)
        {
            _examQuestion.DeletePreTestQuestion(preTestQuestionID);
        }

        public DTO.PreTestQuestion GetPreTestQuestionByID(int preTestQuestionID)
        {
            return Mapper.Map<DTO.PreTestQuestion>(_examQuestion.GetPreTestQuestionByID(preTestQuestionID));
        }

        public DTO.Paged.PagedPreTestQuestion GetAllPagedPreTestQuestionByPreTestID(int preTestID, int skip, int take)
        {
            return Mapper.Map<DTO.Paged.PagedPreTestQuestion>(_examQuestion.GetAllPagedPreTestQuestionByPreTestID(preTestID,skip, take));
        }


        public int AddEducationExamQuestion(DTO.EducationExamQuestion educationExamQuestion)
        {
            return _examQuestion.AddEducationExamQuestion(Mapper.Map<DTO.EducationExamQuestion, HCRGUniversity.Core.Data.Model.EducationExamQuestion>(educationExamQuestion));
        }

        public void UpdateEducationExamQuestion(DTO.EducationExamQuestion educationExamQuestion)
        {
            _examQuestion.UpdateEducationExamQuestion(Mapper.Map<DTO.EducationExamQuestion, HCRGUniversity.Core.Data.Model.EducationExamQuestion>(educationExamQuestion));
        }

        public void DeleteEducationExamQuestion(int courseExamQuestionID)
        {
            _examQuestion.DeleteEducationExamQuestion(courseExamQuestionID);
        }

        public int AddEducationPreTestQuestion(DTO.EducationPreTestQuestion educationExamQuestion)
        {
            return _examQuestion.AddEducationPreTestQuestion(Mapper.Map<DTO.EducationPreTestQuestion, HCRGUniversity.Core.Data.Model.EducationPreTestQuestion>(educationExamQuestion));
        }

        public void UpdateEducationPreTestQuestion(DTO.EducationPreTestQuestion educationExamQuestion)
        {
            _examQuestion.UpdateEducationPreTestQuestion(Mapper.Map<DTO.EducationPreTestQuestion, HCRGUniversity.Core.Data.Model.EducationPreTestQuestion>(educationExamQuestion));
        }

        public void DeleteEducationPreTestQuestion(int coursePreTestQuestionID)
        {
            _examQuestion.DeleteEducationPreTestQuestion(coursePreTestQuestionID);
        }


        public int AddExam(DTO.Exam exam)
        {
            return _examQuestion.AddExam(Mapper.Map<DTO.Exam, HCRGUniversity.Core.Data.Model.Exam>(exam));
        }


        public int UpdateExam(DTO.Exam exam)
        {
            return _examQuestion.UpdateExam(Mapper.Map<DTO.Exam, HCRGUniversity.Core.Data.Model.Exam>(exam));
        }

        public void DeleteExam(int examID)
        {
            _examQuestion.DeleteExam(examID);
        }

        public DTO.Exam GetExamByID(int examID)
        {
            return Mapper.Map<DTO.Exam>(_examQuestion.GetExamByID(examID));
        }

        public DTO.Paged.PagedExam GetAllPagedExam(string name,int skip, int take, int clientID,int orgID)
        {
            return Mapper.Map<DTO.Paged.PagedExam>(_examQuestion.GetAllPagedExam(name,skip, take,clientID,orgID));
        }

        public IEnumerable<DTO.Exam> GetAllActiveExam(int clientID)
        {
            return Mapper.Map<IEnumerable<DTO.Exam>>(_examQuestion.GetAllActiveExam(clientID));
        }     


        public int AddPreTest(DTO.PreTest preTest)
        {
            return _examQuestion.AddPreTest(Mapper.Map<DTO.PreTest, HCRGUniversity.Core.Data.Model.PreTest>(preTest));
        }

        public int UpdatePreTest(DTO.PreTest preTest)
        {
            return _examQuestion.UpdatePreTest(Mapper.Map<DTO.PreTest, HCRGUniversity.Core.Data.Model.PreTest>(preTest));
        }

        public void DeletePreTest(int preTestID)
        {
            _examQuestion.DeletePreTest(preTestID);
        }

        public DTO.PreTest GetPreTestByID(int preTestID)
        {
            return Mapper.Map<DTO.PreTest>(_examQuestion.GetPreTestByID(preTestID));
        }

        public DTO.Paged.PagedPreTest GetAllPagedPreTest(string name, int skip, int take,  int ClientID,int orgID)
        {
            return Mapper.Map<DTO.Paged.PagedPreTest>(_examQuestion.GetAllPagedPreTest(name,skip, take,ClientID,orgID));
        }

        public IEnumerable<DTO.PreTest> GetAllActivePreTest(int clientID)
        {
            return Mapper.Map<IEnumerable<DTO.PreTest>>(_examQuestion.GetAllActivePreTest(clientID));
        }     

        public int AddEvaluation(DTO.Evaluation Evaluation)
        {
            return _examQuestion.AddEvaluation(Mapper.Map<DTO.Evaluation, HCRGUniversity.Core.Data.Model.Evaluation>(Evaluation));
        }

        public int UpdateEvaluation(DTO.Evaluation Evaluation)
        {
            return _examQuestion.UpdateEvaluation(Mapper.Map<DTO.Evaluation, HCRGUniversity.Core.Data.Model.Evaluation>(Evaluation));
        } 

        public int UpdateEvaluationStatus(DTO.Evaluation Evaluation)
        {
            return _examQuestion.UpdateEvaluationStatus(Mapper.Map<DTO.Evaluation, HCRGUniversity.Core.Data.Model.Evaluation>(Evaluation));
        }

        public void DeleteEvaluation(int EvaluationID)
        {
            _examQuestion.DeleteEvaluation(EvaluationID);
        }

        public DTO.Evaluation GetEvaluationByID(int EvaluationID)
        {
            return Mapper.Map<DTO.Evaluation>(_examQuestion.GetEvaluationByID(EvaluationID));
        }

        public DTO.Paged.PagedEvaluation GetAllPagedEvaluation(string name, int skip, int take, int ClientID,int orgID)
        {
            return Mapper.Map<DTO.Paged.PagedEvaluation>(_examQuestion.GetAllPagedEvaluation(name, skip, take, ClientID,orgID));
        }

        public IEnumerable<DTO.Evaluation> GetAllActiveEvaluation(int clientID)
        {
            return Mapper.Map<IEnumerable<DTO.Evaluation>>(_examQuestion.GetAllActiveEvaluation(clientID));
        }


        public int AddEvaluationQuestion(DTO.EvaluationQuestion EvaluationQuestion)
        {
            return _examQuestion.AddEvaluationQuestion(Mapper.Map<DTO.EvaluationQuestion, HCRGUniversity.Core.Data.Model.EvaluationQuestion>(EvaluationQuestion));
        }

        public int AddEvaluationQuestionsFromEvaluationPredefinedQuestions(int EvaluationID)
        {
            return _examQuestion.AddEvaluationQuestionsFromEvaluationPredefinedQuestions(EvaluationID);
        }

        public int UpdateEvaluationQuestion(DTO.EvaluationQuestion EvaluationQuestion)
        {
            return _examQuestion.UpdateEvaluationQuestion(Mapper.Map<DTO.EvaluationQuestion, HCRGUniversity.Core.Data.Model.EvaluationQuestion>(EvaluationQuestion));
        }

        public int UpdateEvaluationQuestionStatus(DTO.EvaluationQuestion EvaluationQuestion)
        {
            return _examQuestion.UpdateEvaluationQuestionStatus(Mapper.Map<DTO.EvaluationQuestion, HCRGUniversity.Core.Data.Model.EvaluationQuestion>(EvaluationQuestion));
        }

        public void DeleteEvaluationQuestion(int EvaluationQuestionID)
        {
            _examQuestion.DeleteEvaluationQuestion(EvaluationQuestionID);
        }

        public DTO.EvaluationQuestion GetEvaluationQuestionByID(int EvaluationQuestionID)
        {
            return Mapper.Map<DTO.EvaluationQuestion>(_examQuestion.GetEvaluationQuestionByID(EvaluationQuestionID));
        }

        public DTO.Paged.PagedEvaluationQuestion GetAllPagedEvaluationQuestionByEvaluationID(int EvaluationID, int skip, int take)
        {
            return Mapper.Map<DTO.Paged.PagedEvaluationQuestion>(_examQuestion.GetAllPagedEvaluationQuestionByEvaluationID(EvaluationID, skip, take));
        }

        public int AddEducationEvaluation(DTO.EducationEvaluation educationEvaluation)
        {
            return _examQuestion.AddEducationEvaluation(Mapper.Map<DTO.EducationEvaluation, HCRGUniversity.Core.Data.Model.EducationEvaluation>(educationEvaluation));
        }

        public void UpdateEducationEvaluation(DTO.EducationEvaluation educationEvaluation)
        {
            _examQuestion.UpdateEducationEvaluation(Mapper.Map<DTO.EducationEvaluation, HCRGUniversity.Core.Data.Model.EducationEvaluation>(educationEvaluation));
        }

        public void DeleteEducationEvaluation(int courseEvaluationID)
        {
            _examQuestion.DeleteEducationEvaluation(courseEvaluationID);
        }

        public DTO.EducationEvaluation GetEducationEvaluationByEducationID(int educationID)
        {
            return Mapper.Map<DTO.EducationEvaluation>(_examQuestion.GetEducationEvaluationByEducationID(educationID));
        }

        public DTO.EducationPreTestQuestion GetEducationPreTestQuestionByEducationID(int educationID)
        {
            return Mapper.Map<DTO.EducationPreTestQuestion>(_examQuestion.GetEducationPreTestQuestionByEducationID(educationID));
        }

        public DTO.EducationExamQuestion GetEducationExamQuestionByEducationID(int educationID)
        {
            return Mapper.Map<DTO.EducationExamQuestion>(_examQuestion.GetEducationExamQuestionByEducationID(educationID));
        }

        public IEnumerable<DTO.PreTestQuestionDetail> GetAllPreTestQuestionDetailByEID(int educationID)
        {
            return Mapper.Map<IEnumerable<DTO.PreTestQuestionDetail>>(_examQuestion.GetAllPreTestQuestionDetailByEID(educationID));
        }

        public IEnumerable<DTO.ExamQuestionDetail> GetAllExamQuestionDetailByEID(int educationID)
        {
            return Mapper.Map<IEnumerable<DTO.ExamQuestionDetail>>(_examQuestion.GetAllExamQuestionDetailByEID(educationID));
        }

        public IEnumerable<DTO.EvaluationQuestionDetail> GetAllEvaluationQuestionDetailByEID(int educationID)
        {
            return Mapper.Map<IEnumerable<DTO.EvaluationQuestionDetail>>(_examQuestion.GetAllEvaluationQuestionDetailByEID(educationID));
        }


    }
}
