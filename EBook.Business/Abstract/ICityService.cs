using Core.Utilities.Results;
using EBook.Entities.Concrete;
using EBook.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.Abstract
{
    public interface ICityService
    {
        IDataResult<List<City>> GetAll();
        IDataResult<City> GetByCityId(int id);
        IDataResult<List<CityDetail>> GetCityDetail();
        IResult Add(City city);
        IResult Delete(City city);
        IResult Update(City city);
    }
}
