using Core.Aspects.AutoFac.Validation;
using Core.Utilities.Results;
using EBook.Business.Abstract;
using EBook.Business.ValidationRules.FluentValidation;
using EBook.DataAccess.Abstract;
using EBook.Entities.Concrete;
using EBook.Entities.DTOs;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using EBook.DataAccess;

namespace EBook.Business.Concrete
{
    [ValidationAspect(typeof(AnswerValidator))]
    public class AnswerManager : IAnswerService
    {
        IAnswerDal _answerDal;

        public AnswerManager(IAnswerDal answerDal)
        {
            _answerDal = answerDal;
        }

        public IResult Add(Answer answer)
        {
            _answerDal.Add(answer);
            return new SuccessResult();
        }

        public IResult Delete(Answer answer)
        {
            _answerDal.Delete(answer);
            return new SuccessResult();
        }

        public IDataResult<List<Answer>> GetAll()
        {
            return new SuccessDataResult<List<Answer>>(_answerDal.GetAll());
        }

        public IDataResult<List<AnswerDetail>> GetAnswerDetail()
        {
            using (EBookContext context=new EBookContext())
            {
                var result = from answer in context.Answers
                             join question in context.Questions
                             on answer.AnswerId equals question.QuestionAnswer
                             join remak in context.Remaks
                             on answer.Remak equals remak.RemakId
                             join teacher in context.Teachers
                             on answer.Owner equals teacher.TeacherId
                             select new AnswerDetail
                             {
                                 OwnerName= teacher.FirstName + " " + teacher.LastName,
                                 QuestionText =question.QuestionText,
                                 QuestionAudio=question.QuestionAudio,
                                 QuestionVideo=question.QuestionVideo,
                                 AnswerText=answer.AnswerText,
                                 AnswerAudio=answer.AnswerAudio,
                                 AnswerPicture=answer.AnswerPicture,
                                 AnswerVideo=answer.AnswerVideo,
                                 QuestionPicture=question.QuestionPicture,
                                 RemakId=remak.RemakId
                             };
                return new SuccessDataResult<List<AnswerDetail>>(result.ToList());
            }
        }

        public IDataResult<Answer> GetByAnswer(int id)
        {
            return new SuccessDataResult<Answer>(_answerDal.Get(answer=>answer.AnswerId==id));
        }

        public IResult Update(Answer answer)
        {
            _answerDal.Update(answer);
            return new SuccessResult();
        }
    }
}
