using Core.DataAccess;
using EBook.Entities.Abstract;
using EBook.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.DataAccess.Abstract
{
    public interface IAdminDal : IEntityRepository<Admin>
    {
      
    }
}
