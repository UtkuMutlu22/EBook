using Core.DataAccess.EntityFramework;
using EBook.DataAccess.Abstract;
using EBook.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.DataAccess.Concrete.EntityFramework
{
    public class EfPriceDal:EfEntityRepositoryBase<Price,EBookContext>,IPriceDal
    {
    }
}
