using Core.Utilities.Results;
using EBook.Business.Abstract;
using EBook.DataAccess.Abstract;
using EBook.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.Concrete
{
    public class TeacherManager : ITeacherService
    {
        ITeacherDal _teacherDal;

        public TeacherManager(ITeacherDal teacherDal)
        {
            _teacherDal = teacherDal;
        }

        public IResult Add(Question question)
        {
            _teacherDal.Add(question);
            return new SuccessResult();
        }

        public IResult Delete(Question question)
        {
            _teacherDal.Delete(question);
            return new SuccessResult();
        }

        public IDataResult<Question> Get(int questionId)
        {
            return new SuccessDataResult<Question>(_teacherDal.Get(teacher=>teacher.QuestionId==questionId));

        }

        public IDataResult<List<Question>> GetAll()
        {
            return new SuccessDataResult<List<Question>>(_teacherDal.GetAll());

        }

        public IDataResult<List<StudentQuestion>> GetByStudentQuestion()
        {
            return new SuccessDataResult<List<StudentQuestion>>(_teacherDal.GetByStudentQuestion());
        }

        public IResult Update(Question question)
        {
            _teacherDal.Update(question);
            return new SuccessResult();
        }
    }
}
