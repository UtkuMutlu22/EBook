using Core.Utilities.Results;
using EBook.Entities.Concrete;
using EBook.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.Abstract
{
    public interface ICosulantService
    {
        IDataResult<List<Cosulant>> GetAll();
        IDataResult<Cosulant> GetByCosulant(int id);
        IDataResult<List<CosulantDetail>> GetCosullantDetail();
        IResult Add(Cosulant cosulant);
        IResult Delete(Cosulant cosulant);
        IResult Update(Cosulant cosulant);
        
    }
}
