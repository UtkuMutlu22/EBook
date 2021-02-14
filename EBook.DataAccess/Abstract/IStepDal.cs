using Core.DataAccess;
using EBook.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.DataAccess.Abstract
{
    public interface IStepDal:IEntityRepository<Step>
    {
    }
}
