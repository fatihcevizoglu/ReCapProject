using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.Description).NotEmpty();
            RuleFor(c => c.Description).MinimumLength(2);
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(10).When(p => p.BrandId == 1);
            RuleFor(c => c.Description).Must(StartWithA);

            RuleFor(c => c.Description).MinimumLength(0).When(c => c.DailyPrice < 0 );


            RuleFor(c => c.CarId);
            
            RuleFor(c => c.BrandId);
            
            RuleFor(c => c.ColorId);
            
            RuleFor(c => c.ModelYear);
            
            RuleFor(c => c.DailyPrice);
           

            RuleFor(c => c.Description);
           

        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }

    }
}
