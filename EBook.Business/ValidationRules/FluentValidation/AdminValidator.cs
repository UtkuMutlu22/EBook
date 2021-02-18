using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.ValidationRules.FluentValidation
{
    public class AdminValidator:AbstractValidator<Admin>
    {
        public AdminValidator()
        {
            RuleFor(admin => admin.FirstName).MaximumLength(3).WithMessage("Kullanıcı adı üç karakterden büyük olmalı");
            RuleFor(admin => admin.LastName).NotEmpty().WithMessage("Soy isim boş geçilemez");
            RuleFor(admin => admin.Mail).Must(Constains).WithMessage("Geçersiz Mail");
            RuleFor(admin => admin.Password).MinimumLength(4).WithMessage("Şifre 4 karakterden uzun olmalı");
        }

        private bool Constains(string arg)
        {
            return arg.Contains("@");
        }
    }
}
