using Core.DataAccess;
using EBook.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.DataAccess.Abstract
{
    public interface IAdminUserDal:IEntityRepository<User>
    {
    }
}
