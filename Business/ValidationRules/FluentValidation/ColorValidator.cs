using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public class ColorValidator:AbstractValidator<Color>
    {
        public ColorValidator()
        {
            RuleFor(x => x.ColorId).NotEmpty();
            RuleFor(x => x.ColorName).NotEmpty();
        }
    }
}
