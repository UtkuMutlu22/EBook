using EBook.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.ValidationRules.FluentValidation
{
    public class VideoValidator:AbstractValidator<Video>
    {
        public VideoValidator()
        {
            RuleFor(video => video.VideoName).MinimumLength(2).WithMessage("Video ismi 2 karakterden uzun olmalıdır");
        }
    }
}
