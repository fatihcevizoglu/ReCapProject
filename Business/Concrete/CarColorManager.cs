using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public class CarColorManager : ICarColorService

    {
        ICarColorDal _carcolorDal;

        public CarColorManager(ICarColorDal carColorDal)
        {
            _carcolorDal = carColorDal;
        }


        public IResult Add(CarColor carColor)
        {
            _carcolorDal.Add(carColor);

            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(CarColor carColor)
        {
            _carcolorDal.Delete(carColor);

            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<CarColor> GetById(int carColor)
        {
            return new SuccessDataResult<CarColor>(_carcolorDal.Get(c => c.ColorId == carColor));
        }

        public IDataResult<List<CarColor>> GettAll()
        {
            return new SuccessDataResult<List<CarColor>>(_carcolorDal.GetAll(), Messages.CarListed);

        }

        public IResult Update(CarColor carColor)
        {
            _carcolorDal.Update(carColor);

            return new SuccessResult(Messages.CarUpdated);

        }
    }
}
