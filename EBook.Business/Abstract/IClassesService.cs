using Core.Utilities.Results;
using EBook.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.Abstract
{
   public interface IClassesService
    {
        IDataResult<List<Classes>> GetAll();
        IDataResult<Classes> Get(int classId);
        IResult Add(Classes classes);
        IResult Update(Classes classes);
        IResult Delete(Classes classes);
    }
}
