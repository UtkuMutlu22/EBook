using Core.Utilities.Results;
using EBook.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.Abstract
{
    public interface ITeacherService
    {
        IDataResult<List<Question>> GetAll();
        IDataResult<List<StudentQuestion>> GetByStudentQuestion();
        IDataResult<Question> Get(int questionId);
        IResult Add(Question question);
        IResult Update(Question question);
        IResult Delete(Question question);
    }
}
