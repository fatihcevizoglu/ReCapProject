using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental rental)
        {
            var rest = _rentalDal.GetAll();
            foreach (var item in rest)
            {
                if (item.CarId == rental.CarId && item.ReturnDate == null)
                {
                    return new ErrorResult(Messages.CarNotDelivered);
                }
            }
           
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.CarAdded);
            

        }

        [ValidationAspect(typeof(RentalValidator))]
        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);

            return new SuccessResult(Messages.CarDeleted);

        }

        public IDataResult<Rental> GetById(int rental)
        {
          


          return new SuccessDataResult<Rental>(_rentalDal.Get(c => c.Id == rental));
           
        }

        public IDataResult<List<Rental>> GettAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.CarListed);

        }

        [ValidationAspect(typeof(RentalValidator))]
        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.CarUpdated);

        }

    }
}
