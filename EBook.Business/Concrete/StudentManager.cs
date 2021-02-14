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

        public IResult Add(Student student)
        {
            _studentDal.Add(student);
            return new SuccessResult();
        }

        public IResult Delete(Student student)
        {
            _studentDal.Delete(student);
            return new SuccessResult();
        }

        public IDataResult<Student> Get(int studentId)
        {
            return new SuccessDataResult<Student>(_studentDal.Get(student=>student.StudentId==studentId));

        }

        public IDataResult<List<Student>> GetAll()
        {
            return new SuccessDataResult<List<Student>>(_studentDal.GetAll());
        }

        public IResult Update(Student student)
        {
            _studentDal.Update(student);
            return new SuccessResult();
        }
    }
}
