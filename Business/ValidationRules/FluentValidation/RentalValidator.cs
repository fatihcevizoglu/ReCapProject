using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.Id);

            RuleFor(r => r.CarId);
            RuleFor(r => r.CustomerId);
            RuleFor(r => r.RentDate);
            RuleFor(r => r.ReturnDate);

           

            var rest = _rentalDal.GetAll();
            foreach (var item in rest)
            {
                if (item.CarId == rental.CarId && item.ReturnDate == null)
                {
                    return new ErrorResult(Messages.CarNotDelivered);
                }
            }
        }






    }
}
