using EBook.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.ValidationRules.FluentValidation
{
    public class AudioValidator:AbstractValidator<Audio>
    {
        public AudioValidator()
        {
            RuleFor(audio => audio.AudioName).NotEmpty().WithMessage("Lütfen ses dosyasına isim veriniz");
            
        }
    }
}
