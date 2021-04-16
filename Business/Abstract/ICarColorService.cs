﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICarColorService
    {
        IDataResult<List<CarColor>> GettAll();

        IDataResult<CarColor> GetById(int carColor);

        IResult Add(CarColor carColor);
        IResult Delete(CarColor carColor);
        IResult Update(CarColor carColor);

    }
}
