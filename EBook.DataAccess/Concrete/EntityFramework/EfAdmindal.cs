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
    public class EfAdmindal : EfEntityRepositoryBase<Admin, EBookContext>, IAdminDal, IAdminDetail
    {
        public List<AdminDetail> GetAdminDetails()
        {
            using (EBookContext context=new EBookContext())
            {
                var result = from user in context.Users
                             join admin in context.Admins
                             on user.UserId equals admin.UserId
                             select new AdminDetail
                             {
                                 Id = admin.UserId,
                                 Name=admin.FirstName,
                                 Mail=admin.Mail,
                                  RegisterDate=admin.RegisterDate
                             };
                return result.ToList();
            }
        }

        public AdminDetail GetByAdminDetail(int id)
        {
            using (EBookContext context=new EBookContext())
            {
                var result = from user in context.Users
                             join admin in context.Admins
                             on user.UserId equals admin.UserId
                             select new AdminDetail
                             {
                                 Id = admin.UserId,
                                 Name = admin.FirstName,
                                 Mail = admin.Mail,
                                 RegisterDate = admin.RegisterDate
                             };
                return result.FirstOrDefault(user => user.Id == id);
            }
        }
    }
}
