using Core.Utilities.Results;
using EBook.Business.Abstract;
using EBook.DataAccess.Abstract;
using EBook.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.Concrete
{
    public class ITeacherManager : ITeacherService
    {
        ITeacherDal _teacherDal;

        public ITeacherManager(ITeacherDal teacherDal)
        {
            _teacherDal = teacherDal;
        }

        public IResult Add(Teacher teacher)
        {
            _teacherDal.Add(teacher);
            return new SuccessResult();
        }

        public IResult Delete(Teacher teacher)
        {
            _teacherDal.Delete(teacher);
            return new SuccessResult();
        }

        public IDataResult<Teacher> Get(int teacherId)
        {
            return new SuccessDataResult<Teacher>(_teacherDal.Get(teacher=>teacher.TeacherId==teacherId));

        }

        public IDataResult<List<Teacher>> GetAll()
        {
            return new SuccessDataResult<List<Teacher>>(_teacherDal.GetAll());

        }

        public IResult Update(Teacher teacher)
        {
            _teacherDal.Update(teacher);
            return new SuccessResult();
        }
    }
}
