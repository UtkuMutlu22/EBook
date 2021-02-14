using Core.Utilities.Results;
using EBook.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.Abstract
{
    public interface IBookService
    {
        IDataResult<List<Book>> GetAll();
        IDataResult<Book> Get(int bookId);
        IResult Add(Book book);
        IResult Update(Book book);
        IResult Delete(Book book);
    }
}
