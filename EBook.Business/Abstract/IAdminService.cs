using Core.Utilities.Results;
using EBook.Entities.Abstract;
using EBook.Entities.Concrete;
using EBook.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.Abstract
{
    public interface IAdminService
    {
        IDataResult<List<Admin>> GetAll();
        IDataResult<Admin> GetByAdmin(int id);
        IDataResult<List<AdminDetail>> GetAdminDetail();
        IResult Add(Admin admin);
        IResult Delete(Admin admin);
        IResult Update(Admin admin);
    }
}
