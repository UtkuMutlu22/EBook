using EBook.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.ValidationRules.FluentValidation
{
    public class StudentValidator:AbstractValidator<Question>
    {
        public StudentValidator()
        {
            RuleFor(student => student.BookId).NotEmpty().WithMessage("Kullanıcı adı boş olamaz");
            RuleFor(student => student.QuestionAudio).NotEmpty();
            RuleFor(student => student.QuestionPicture).EmailAddress();
            RuleFor(student => student.QuestionText).NotEmpty();
            RuleFor(student => student.QuestionVideo).Empty();
             

            RuleFor(student => student.QuestionAnswer).Must(StartWithA);
        }

        

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
