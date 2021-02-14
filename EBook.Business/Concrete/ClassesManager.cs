using Core.Utilities.Results;
using EBook.Business.Abstract;
using EBook.DataAccess.Abstract;
using EBook.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.Concrete
{
    public class ClassesManager : IClassesService
    {
        IClassesDal _classesDal;

        public ClassesManager(IClassesDal classesDal)
        {
            _classesDal = classesDal;
        }

        public IResult Add(Classes classes)
        {
            _classesDal.Add(classes);
            return new SuccessResult(); ;
        }

        public IResult Delete(Classes classes)
        {
            _classesDal.Delete(classes);
            return new SuccessResult(); ;
        }

        public IDataResult<Classes> Get(int classId)
        {
            return new SuccessDataResult<Classes>(_classesDal.Get(classes=>classes.ClassId==classId));
        }

        public IDataResult<List<Classes>> GetAll()
        {
            return new SuccessDataResult<List<Classes>>(_classesDal.GetAll());
        }

        public IResult Update(Classes classes)
        {
            _classesDal.Update(classes);
            return new SuccessResult(); ;
        }
    }
}
