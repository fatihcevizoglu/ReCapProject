using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.Id);

            RuleFor(r => r.CarId);
            RuleFor(r => r.CustomerId);
            RuleFor(r => r.RentDate);
            RuleFor(r => r.ReturnDate);

           

         
        }






    }
}
