using EBook.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.ValidationRules.FluentValidation
{
    public class PictureValidator:AbstractValidator<Picture>
    {
        public PictureValidator()
        {
            RuleFor(picture => picture.PictureName).NotEmpty().WithMessage("İsim boş geçilemez");
        }
    }
}
