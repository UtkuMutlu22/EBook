using EBook.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.ValidationRules.FluentValidation
{
    public class StudentValidator:AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(student => student.FirstName).MaximumLength(3).WithMessage("Kullanıcı adı üç karakterden büyük olmalı");
            RuleFor(student => student.LastName).NotEmpty().WithMessage("Soy isim boş geçilemez");
            RuleFor(student => student.Mail).EmailAddress().WithMessage("Geçersiz mail");
            RuleFor(student => student.Password).MinimumLength(4).WithMessage("Şifre 4 karakterden uzun olmalı");
        }

       
    }
}
