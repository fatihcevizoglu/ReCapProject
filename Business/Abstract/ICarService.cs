﻿using Core.Utilities;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        
       IDataResult< List<Car>> GetAllByBrandId(int brandId);
        
        IDataResult<List<Car>> GetByColorId(int colorId);
        
       IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max);

        IDataResult<List<CarDetailDto>> GetCarDetails();

      
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);

        IResult AddTransactionalTest(Car car);
    }
}
