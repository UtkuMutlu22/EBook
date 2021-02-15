using Core.DataAccess.EntityFramework;
using EBook.DataAccess.Abstract;
using EBook.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace EBook.DataAccess.Concrete.EntityFramework
{
    public class EfTeacherDal : EfEntityRepositoryBase<Question, EBookContext>, ITeacherDal
    {
        public List<StudentQuestion> GetByStudentQuestion(Expression<Func<StudentQuestion,bool>> filter=null)
        {
            using (EBookContext context =new EBookContext())
            {
                return filter == null ? context.Set<StudentQuestion>().ToList()
                    : context.Set<StudentQuestion>().Where(filter).ToList();

            }
        }

        
    }
}
