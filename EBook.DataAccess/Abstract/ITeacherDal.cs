using Core.DataAccess;
using EBook.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EBook.DataAccess.Abstract
{
    public interface ITeacherDal:IEntityRepository<Question>
    {
        List<StudentQuestion> GetByStudentQuestion(Expression<Func<StudentQuestion, bool>> filter = null);
    }
}
