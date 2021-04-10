﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    class BrandManager : IBrandService
    {
        IBrandDal  _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }


        public Brand GetById(int brandId)
        {
            return _brandDal.Get(c => c.BrandId == brandId);
        }

        public List<Brand> GettAll()
        {
            return _brandDal.GetAll();
        }
    }
}
