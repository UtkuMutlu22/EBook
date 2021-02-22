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
    public class CosulantManager : ICosulantService
    {
        ICosulantDal _cosulantDal;

        public CosulantManager(ICosulantDal cosulantDal)
        {
            _cosulantDal = cosulantDal;
        }

        public IResult Add(Cosulant cosulant)
        {
            _cosulantDal.Add(cosulant);
            return new SuccessResult();
        }

        public IResult Delete(Cosulant cosulant)
        {
            _cosulantDal.Add(cosulant);
            return new SuccessResult();
        }

        public IDataResult<List<Cosulant>> GetAll()
        {
            return new SuccessDataResult<List<Cosulant>>(_cosulantDal.GetAll());
        }

        public IDataResult<Cosulant> GetByCosulant(int id)
        {
            return new SuccessDataResult<Cosulant>(_cosulantDal.Get(cosulant=>cosulant.ConsulantId==id));
        }

        public IDataResult<List<CosulantDetail>> GetCosullantDetail()
        {
            using (EBookContext context=new EBookContext())
            {
                var result = from cosulant in context.Cosulants
                             join student in context.Students
                             on cosulant.StudentId equals student.StudentId
                             join category in context.Categories
                             on cosulant.CategoryId equals category.CategoryId
                             select new CosulantDetail
                             {
                                 ConsulantName=cosulant.FirstName,
                                 ConsulantLastName=cosulant.LastName,
                                 StudentName=student.FirstName,
                                 ConsulantSpeciality=category.CategoryName
                                
                             };
                return new SuccessDataResult<List<CosulantDetail>>(result.ToList());
            }
        }

        public IResult Update(Cosulant cosulant)
        {
            _cosulantDal.Add(cosulant);
            return new SuccessResult();
        }
    }
}
