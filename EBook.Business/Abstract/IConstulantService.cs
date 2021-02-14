using Core.Utilities.Results;
using EBook.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.Abstract
{
    public interface IConstulantService
    {
        IDataResult<List<Constulant>> GetAll();
        IDataResult<Constulant> Get(int constulantId);
        IResult Add(Constulant constulant);
        IResult Update(Constulant constulant);
        IResult Delete(Constulant constulant);
    }
}
