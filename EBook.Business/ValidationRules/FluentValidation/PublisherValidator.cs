using EBook.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.ValidationRules.FluentValidation
{
    public class PublisherValidator:AbstractValidator<Publisher>
    {
        public PublisherValidator()
        {
            RuleFor(publisher => publisher.PublisherName).NotEmpty().WithMessage("Yayın evinin ismini giriniz");
            RuleFor(publisher => publisher.PublisherCity).NotEmpty().WithMessage("Lütfen yayın evinin bulunduğu şehri giriniz");
            RuleFor(publisher => publisher.PublisherPhoto).NotEmpty().WithMessage("Lütfen yayın evinin logosunu yükleyin");
        }
    }
}
