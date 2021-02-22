using Core.Utilities.Results;
using EBook.Business.Abstract;
using EBook.DataAccess;
using EBook.DataAccess.Abstract;
using EBook.Entities.Concrete;
using EBook.Entities.DTOs;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.Concrete
{
    public class CityManager : ICityService
    {
        ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public IResult Add(City city)
        {
            _cityDal.Add(city);
            return  new SuccessResult();
        }

        public IResult Delete(City city)
        {
            _cityDal.Delete(city);
            return new SuccessResult();
        }

        public IDataResult<List<City>> GetAll()
        {
            return new SuccessDataResult<List<City>>(_cityDal.GetAll());
        }

        public IDataResult<City> GetByCityId(int id)
        {
            return new SuccessDataResult<City>(_cityDal.Get(city => city.CıtyId == id));
        }

        public IDataResult<List<CityDetail>> GetCityDetail()
        {
            using (EBookContext context=new EBookContext())
            {
                var result = from city in context.Cities
                             select new CityDetail
                             {
                                 CityName = city.CityName
                             };
            return new SuccessDataResult<List<CityDetail>>(result.ToList());
            }
        }

        public IResult Update(City city)
        {
            _cityDal.Update(city);
            return new SuccessResult();
        }
    }
}
