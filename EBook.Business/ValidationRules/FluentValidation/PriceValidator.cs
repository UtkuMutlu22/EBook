using EBook.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.ValidationRules.FluentValidation
{
    public class PriceValidator:AbstractValidator<Price>
    {
        public PriceValidator()
        {
            RuleFor(price => price.Amount).NotEmpty().WithMessage("Tutar boş geçilemez");
            RuleFor(price => price.ContextId).NotEmpty().WithMessage("Kaynak adı boş geçilemez");
            RuleFor(price => price.StudentId).NotEmpty().WithMessage("Lütfen kullanıcı adını giriniz");
        }
    }
}
