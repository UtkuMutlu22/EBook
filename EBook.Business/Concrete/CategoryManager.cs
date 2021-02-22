using Core.Utilities.Results;
using EBook.Business.Abstract;
using EBook.DataAccess;
using EBook.DataAccess.Abstract;
using EBook.Entities.Concrete;
using EBook.Entities.DTOs;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IResult Add(Category category)
        {
            _categoryDal.Add(category);
            return new SuccessResult();
        }

        public IResult Delete(Category category)
        {
            _categoryDal.Delete(category);
            return new SuccessResult();
        }

        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
        }

        public IDataResult<Category> GetByCategoryId(int id)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(category => category.CategoryId == id));
        }

        public IDataResult<List<CategoryDetail>> GetCategoryDetail()
        {
            using (EBookContext context = new EBookContext())
            {
                var result = from category in context.Categories
                             select new CategoryDetail
                             {
                                 CategoryName=category.CategoryName
                             };
                return new SuccessDataResult<List<CategoryDetail>>(result.ToList());
                           
            }
        }

        public IResult Update(Category category)
        {
            _categoryDal.Update(category);
            return new SuccessResult();
        }
    }
}
