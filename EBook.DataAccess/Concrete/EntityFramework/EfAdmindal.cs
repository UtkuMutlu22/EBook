using Core.DataAccess.EntityFramework;
using EBook.DataAccess.Abstract;
using EBook.Entities.Concrete;
using EBook.Entities.DTOs;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EBook.DataAccess.Concrete.EntityFramework
{
    public class EfAdmindal : EfEntityRepositoryBase<Admin, EBookContext>, IAdminDal
    {
       
    }
}
