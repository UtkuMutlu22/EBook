using Core.Utilities.Results;
using EBook.Business.Abstract;
using EBook.DataAccess.Abstract;
using EBook.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.Concrete
{
    public class StepManager : IStepService
    {
        IStepDal _stepDal;

        public StepManager(IStepDal stepDal)
        {
            _stepDal = stepDal;
        }

        public IResult Add(Step step)
        {
            _stepDal.Add(step);
            return new SuccessResult();
        }

        public IResult Delete(Step step)
        {
            _stepDal.Delete(step);
            return new SuccessResult();
        }

        public IDataResult<Step> Get(int stepId)
        {
            return new SuccessDataResult<Step>(_stepDal.Get(step => step.StepId==stepId));

        }

        public IDataResult<List<Step>> GetAll()
        {
            return new SuccessDataResult<List<Step>>(_stepDal.GetAll());

        }

        public IResult Update(Step step)
        {
            _stepDal.Update(step);
            return new SuccessResult();
        }
    }
}
