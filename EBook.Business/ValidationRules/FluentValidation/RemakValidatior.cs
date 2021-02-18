using EBook.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.ValidationRules.FluentValidation
{
    public class RemakValidatior : AbstractValidator<Remak>
    {
        public RemakValidatior()
        {
            RuleFor(remak => remak.Text).MinimumLength(5).WithMessage("Yorumunuz beş karakterden uzun olmalı");
            RuleFor(remak => remak.Owner).NotEmpty().WithMessage("Kullanıcı Adınızı giriniz");
        }
    }
}
