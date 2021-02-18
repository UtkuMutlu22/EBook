using EBook.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.ValidationRules.FluentValidation
{
   public  class QuestionValidation:AbstractValidator<Question>
    {
        public QuestionValidation()
        {
            RuleFor(question => question.QuestionText).MinimumLength(2).WithMessage("Soru metni iki karakterden kısa olamaz");
            RuleFor(question => question.QuestionAnswer).NotEmpty().WithMessage("Lütfen Sorunun cevabını giriniz");
            RuleFor(question => question.BookId).NotEmpty().WithMessage("Kitap adı boş Geçilemez");
            RuleFor(questin => questin.QuestionText).Must(EndsWith).WithMessage("Sorular soru işareti ile bitmelidir");

        }

        private bool EndsWith(string arg)
        {
            return arg.EndsWith("?");
        }
    }
}
