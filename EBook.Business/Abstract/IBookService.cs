using Core.Utilities.Results;
using EBook.Entities.Concrete;
using EBook.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.Abstract
{
    public interface IBookService
    {
        IDataResult<List<Book>> GetAll();
        IDataResult<Book> GetByBookId(int bookid);
        IDataResult<List<BookDetail>> GetBookDetail();
        IDataResult<List<Book>> GetAllByBookCategory();
        IResult Add(Book book);
        IResult Update(Book book);
        IResult Delete(Book book);
    }
}
