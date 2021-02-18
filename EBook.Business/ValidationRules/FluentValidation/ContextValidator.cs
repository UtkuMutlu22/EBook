using EBook.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.ValidationRules.FluentValidation
{
    public class ContextValidator:AbstractValidator<Context>
    {
        public ContextValidator()
        {
            RuleFor(context => context.BookId).NotEmpty().WithMessage("Kaynak adı boş geçilemez");
            RuleFor(context => context.ContextText).NotEmpty().WithMessage("Açıklama giriniz");
            
        }
    }
}
