﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public class BrandManager : IBrandService
    {
        IBrandDal  _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);

            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);

            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<Brand> GetById(int brandId)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(c => c.BrandId == brandId));
            
        }

        public IDataResult<List<Brand>> GettAll()
        {
            return new SuccessDataResult<List<Brand>>( _brandDal.GetAll(), Messages.CarListed);
       
        }

        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);

            return new SuccessResult(Messages.CarUpdated);
        }

        
    }
}
