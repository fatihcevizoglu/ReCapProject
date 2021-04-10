using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarDatBaseContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarDatBaseContext context = new CarDatBaseContext())
            {
                var result = from c in context.Car
                             join b in context.Brand
                             on c.BrandId equals b.BrandId
                             join cl in context.CarColor
                             on c.ColorId equals cl.ColorId
                             select new CarDetailDto { CarId = c.CarId, BrandName = b.BrandName, ColorName = cl.ColorName, DailyPrice = c.DailyPrice };
                return result.ToList();
            }
        }
    }
}
