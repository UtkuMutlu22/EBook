using EBook.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.ValidationRules.FluentValidation
{
    public class BookValidator:AbstractValidator<Book>
    {
        public BookValidator()
        {
            RuleFor(book => book.BookName).NotEmpty().WithMessage("Kitap Adı boş geçilemez");
            RuleFor(book => book.BookTitle).NotEmpty().WithMessage("Kitabın seviyesi boş geçilemez");
            RuleFor(book => book.Publisher).NotEmpty().WithMessage("Lütfen yayın evini giriniz");
            RuleFor(book => book.Description).NotEmpty().WithMessage("Lütfen açıklama giriniz");
            RuleFor(book => book.DateOfIssue).NotEmpty().WithMessage("Lütfen Basım yılını giriniz");
        }
    }
}
