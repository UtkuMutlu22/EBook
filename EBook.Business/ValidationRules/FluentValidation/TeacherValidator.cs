using EBook.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.ValidationRules.FluentValidation
{
    public class TeacherValidator:AbstractValidator<Teacher>
    {
        public TeacherValidator()
        {
            RuleFor(teacher => teacher.FirstName).MaximumLength(3).WithMessage("Kullanıcı adı üç karakterden büyük olmalı");
            RuleFor(teacher => teacher.LastName).NotEmpty().WithMessage("Soy isim boş geçilemez");
            RuleFor(teacher => teacher.Mail).EmailAddress().WithMessage("Geçersiz mail");
            RuleFor(teacher => teacher.Password).MinimumLength(4).WithMessage("Şifre 4 karakterden uzun olmalı");
            RuleFor(teacher => teacher.TeacherSpeciality).NotEmpty().WithMessage("Uzmanlık alanı giriniz");
        }

       
    }
}
