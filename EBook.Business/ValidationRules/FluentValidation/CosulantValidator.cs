using EBook.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.ValidationRules.FluentValidation
{
    public class CosulantValidator:AbstractValidator<Cosulant>
    {
        public CosulantValidator()
        {
            RuleFor(cosulant => cosulant.TeacherId).NotEmpty().WithMessage("Lütfen kullanıcı adınızı giriniz");
        }
    }
}
