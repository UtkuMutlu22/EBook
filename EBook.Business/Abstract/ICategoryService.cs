using Core.Utilities.Results;
using EBook.Entities.Concrete;
using EBook.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetAll();
        IDataResult<Category> GetByCategoryId(int id);
        IDataResult<List<CategoryDetail>> GetCategoryDetail();
        IResult Add(Category category);
        IResult Delete(Category category);
        IResult Update(Category category);
    }
}
