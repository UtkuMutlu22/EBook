using Core.Utilities.Results;
using EBook.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.Abstract
{
   public interface IStudentService
    {
        IDataResult<List<Student>> GetAll();
        IDataResult<Student> Get(int studentId);
        IResult Add(Student student);
        IResult Update(Student student);
        IResult Delete(Student student);
    }
}
