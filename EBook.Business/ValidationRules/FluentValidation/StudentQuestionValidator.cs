using EBook.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.ValidationRules.FluentValidation
{
    public class StudentQuestionValidator:AbstractValidator<StudentQuestion>
    {
        public StudentQuestionValidator()
        {
            RuleFor(question => question.BookId).NotEmpty().WithMessage("Kitap Adı boş geçilemez");
            RuleFor(question => question.QuestionText).MinimumLength(2).WithMessage("Soru metni iki karakterden uzun olmalıdır");
            RuleFor(question => question.QuestionText).Must(EndsWith).WithMessage("Sorular soru işareti ile bitmelidir");
        }

        private bool EndsWith(string arg)
        {
            return arg.EndsWith("?");
        }
    }
}
