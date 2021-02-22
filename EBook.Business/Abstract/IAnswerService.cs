using Core.Utilities.Results;
using EBook.Entities.Concrete;
using EBook.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.Abstract
{
    public interface IAnswerService
    {
        IDataResult<List<Answer>> GetAll();
        IDataResult<Answer> GetByAnswer(int id);
        IDataResult<List<AnswerDetail>> GetAnswerDetail();
        IResult Add(Answer answer);
        IResult Delete(Answer answer);
        IResult Update(Answer answer);

    }
}
