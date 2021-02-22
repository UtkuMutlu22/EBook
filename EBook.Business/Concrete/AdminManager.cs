using Core.Utilities.Results;
using EBook.Business.Abstract;
using EBook.DataAccess.Abstract;
using EBook.Entities.Concrete;
using EBook.Entities.DTOs;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using EBook.DataAccess;
using EBook.Business.ValidationRules.FluentValidation;
using Core.Aspects.AutoFac.Validation;

namespace EBook.Business.Concrete
{
    [ValidationAspect(typeof(AdminValidator))]
    public class AdminManager : IAdminService
    {
        IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        
        public IResult Add(Admin admin)
        {
            _adminDal.Add(admin);
            return new SuccessResult();
        }

        public IResult Delete(Admin admin)
        {
            _adminDal.Delete(admin);
            return new SuccessResult();
        }

        public IDataResult<List<AdminDetail>> GetAdminDetail()
        {
            using (EBookContext context=new EBookContext())
            {
                var result = from admin in context.Admins
                             select new AdminDetail
                             {
                                 Name = admin.FirstName+" "+admin.LastName,
                                 Mail=admin.Mail,
                                 RegisterDate=admin.RegisterDate
                                    
                             };
                return new SuccessDataResult<List<AdminDetail>>(result.ToList());
            }
        }

        public IDataResult<List<Admin>> GetAll()
        {
            _adminDal.GetAll();
            return new SuccessDataResult<List<Admin>>(_adminDal.GetAll());
        }

        public IDataResult<Admin> GetByAdmin(int id)
        {
            var result = _adminDal.Get(admin => admin.UserId == id);
          
            
                return new SuccessDataResult<Admin>(result);
            
            
        }

        public IResult Update(Admin admin)
        {
            _adminDal.Update(admin);
            return new SuccessResult();
        }
    }
}
