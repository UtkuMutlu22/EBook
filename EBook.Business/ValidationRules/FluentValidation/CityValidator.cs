using EBook.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.ValidationRules.FluentValidation
{
    public class CityValidator:AbstractValidator<City>
    {
        public CityValidator()
        {
            RuleFor(city => city.CityName).NotEmpty().WithMessage("Sehir adı boş geçilemez");
        }
    }
}
