using Core.Utilities.Results;
using EBook.Business.Abstract;
using EBook.DataAccess.Abstract;
using EBook.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.Concrete
{
    public class StudentManager : IStudentService
    {
        IStudentDal _studentDal;

        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }

        public IResult Add(Question question)
        {
            _studentDal.Add(question);
            return new SuccessResult();
        }

        public IResult Delete(Question question)
        {
            _studentDal.Delete(question);
            return new SuccessResult();
        }

        public IDataResult<Question> Get(int questionId)
        {
            return new SuccessDataResult<Question>(_studentDal.Get(student=>student.QuestionId==questionId));

        }

        public IDataResult<List<Question>> GetAll()
        {
            return new SuccessDataResult<List<Question>>(_studentDal.GetAll());
        }

        public IResult Update(Question question)
        {
            _studentDal.Update(question);
            return new SuccessResult();
        }
    }
}
