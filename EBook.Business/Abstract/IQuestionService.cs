using Core.Utilities.Results;
using EBook.Entities.Concrete;
using EBook.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.Abstract
{
    public interface IQuestionService
    {
        IDataResult<List<Question>> GetAll();
        IDataResult<Question> Get(int questionId);
        IDataResult<List<QuestionDetail>> GetAllQuestionDetail();
        IResult Add(Question question);
        IResult Update(Question question);
        IResult Delete(Question question);
    }
}
