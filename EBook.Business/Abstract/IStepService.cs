using Core.Utilities.Results;
using EBook.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.Abstract
{
    public interface IStepService
    {
        IDataResult<List<Step>> GetAll();
        IDataResult<Step> Get(int stepId);
        IResult Add(Step step);
        IResult Update(Step step);
        IResult Delete(Step step);
    }
}
