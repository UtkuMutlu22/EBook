using Core.Utilities.Results;
using EBook.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.Abstract
{
   public interface IStudentService
    {
        IDataResult<List<Question>> GetAll();
        IDataResult<Question> Get(int question);
        IResult Add(Question question);
        IResult Update(Question question);
        IResult Delete(Question question);
    }
}
