using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    class CarColorValidator : AbstractValidator<CarColor>
    {
        public CarColorValidator()
        {
            RuleFor(c => c.ColorId);
            RuleFor(c => c.ColorName);
        }

    }
}
