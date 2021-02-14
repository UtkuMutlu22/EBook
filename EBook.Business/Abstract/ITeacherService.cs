using Core.Utilities.Results;
using EBook.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.Abstract
{
    public interface ITeacherService
    {
        IDataResult<List<Teacher>> GetAll();
        IDataResult<Teacher> Get(int teacherId);
        IResult Add(Teacher teacher);
        IResult Update(Teacher teacher);
        IResult Delete(Teacher teacher);
    }
}
