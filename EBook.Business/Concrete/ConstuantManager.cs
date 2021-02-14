using Core.Utilities.Results;
using EBook.Business.Abstract;
using EBook.DataAccess.Abstract;
using EBook.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.Concrete
{
    public class ConstuantManager : IConstulantService
    {
        IConstulantDal _constulantDal;
        public IResult Add(Constulant constulant)
        {
            _constulantDal.Add(constulant);
            return new SuccessResult();
        }

        public IResult Delete(Constulant constulant)
        {
            _constulantDal.Delete(constulant);
            return new SuccessResult();
        }

        public IDataResult<Constulant> Get(int constulantId)
        {
            return new SuccessDataResult<Constulant>(_constulantDal.Get(constulant=>constulant.ConculantId==constulantId));
        }

        public IDataResult<List<Constulant>> GetAll()
        {
            return
            new SuccessDataResult<List<Constulant>>(_constulantDal.GetAll());
        }

        public IResult Update(Constulant constulant)
        {
            _constulantDal.Update(constulant);
            return new SuccessResult();
        }
    }
}
