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
using EBook.Business.ValidationRules.FluentValidation;
using Core.Aspects.AutoFac.Validation;

namespace EBook.Business.Concrete
{
    [ValidationAspect(typeof(BookValidator))]
    public class BookManager : IBookService
    {
        IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }
        
        public IResult Add(Book book)
        {
            _bookDal.Add(book);
            return new SuccessResult();
        }

        public IResult Delete(Book book)
        {
            _bookDal.Delete(book);
            return new SuccessResult();
        }

        public IDataResult<List<Book>> GetAll()
        {
            _bookDal.GetAll();
            return new SuccessDataResult<List<Book>>(_bookDal.GetAll());
        }

        public IDataResult<List<Book>> GetAllByBookCategory()
        {
            using (EBookContext context=new EBookContext())
            {
                var result = from book in context.Books
                             join category in context.Categories
                             on book.CategoryId equals category.CategoryId
                             select book.BookId == category.CategoryId;
                return new SuccessDataResult<List<Book>>(result.ToList());
            }
            
        }

        public IDataResult<List<BookDetail>> GetBookDetail()
        {
            using (EBookContext context = new EBookContext())
            {
                var result = from book in context.Books
                             join category in context.Categories
                             on book.CategoryId equals category.CategoryId
                             join publisher in context.Publishers
                             on book.PublisherId equals publisher.PublisherId
                             select new BookDetail
                             {
                                 BookId=book.BookId,
                                BookName=book.BookName,
                                CategoryName=category.CategoryName,
                                Publisher=publisher.PublisherName,
                                DateOfIssue=book.DateOfIssue,
                                Description=book.Description

                             };

                return new SuccessDataResult<List<BookDetail>>(result.ToList());
            }
        }

        public IDataResult<Book> GetByBookId(int bookid)
        {
            return new SuccessDataResult<Book>(_bookDal.Get(book=>book.BookId==bookid));
        }

        public IResult Update(Book book)
        {
            _bookDal.Update(book);
            return new SuccessResult();
        }
    }
}
