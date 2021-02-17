using EBook.Entities.Concrete;
using EBook.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EBook.DataAccess.Abstract
{
    public interface ITeacherDetail
    {
        List<TeacherDetail> GetTeacherDetails();
        TeacherDetail GetByTeacherDetail(Expression<Func<Teacher, bool>> filter);
    }
}
