using Core.Utilities.Results;
using EBook.Entities.Concrete;
using EBook.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.Abstract
{
    public interface IContextService
    {
        IDataResult<List<Context>> GetAll();
        IDataResult<Context> GetByContext(int id);
        IDataResult<List<ContextDetail>> GetContextDetail();
        IResult Add(Context context);
        IResult Delete(Context context);
        IResult Update(Context context);
    }
}
