using EBook.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.ValidationRules.FluentValidation
{
    public class AnswerValidator:AbstractValidator<Answer>
    {
        public AnswerValidator()
        {
            RuleFor(answer => answer.AnswerText).NotEmpty().WithMessage("Cevap Boş Geçilemez");
            RuleFor(answer => answer.Owner).NotEmpty().WithMessage("Lütfen kullanıcı adınızı giriniz");
            
        }
    }
}
