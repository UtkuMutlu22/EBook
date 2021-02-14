using Core.Utilities.Results;
using EBook.Business.Abstract;
using EBook.DataAccess.Abstract;
using EBook.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.Concrete
{
    public class QuestionManager : IQuestionService
    {
        IQuestionDal _questionDal;

        public QuestionManager(IQuestionDal questionDal)
        {
            _questionDal = questionDal;
        }

        public IResult Add(Question question)
        {
            _questionDal.Add(question);
            return new SuccessResult();
        }

        public IResult Delete(Question question)
        {
            _questionDal.Delete(question);
            return new SuccessResult();
        }

        public IDataResult<Question> Get(int questionId)
        {
            return new SuccessDataResult<Question>(_questionDal.Get(question=>question.QuestionId==questionId));
        }

        public IDataResult<List<Question>> GetAll()
        {
            return new SuccessDataResult<List<Question>>(_questionDal.GetAll());
        }

        public IResult Update(Question question)
        {
            _questionDal.Update(question);
            return new SuccessResult();
        }
    }
}
