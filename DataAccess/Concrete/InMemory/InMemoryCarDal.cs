using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory
{
   public class InMemoryCarDal: ICarDal
    {

        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{CarId = 1 ,BrandId = 1 , ColorId = 5 ,DailyPrice = 50099, Description = "Suv" ,ModelYear = "2016" },
                new Car{CarId = 2 ,BrandId = 1 , ColorId = 3 ,DailyPrice = 60099, Description = "Sedan" ,ModelYear = "2019" },
                new Car{CarId = 3 ,BrandId = 1 , ColorId = 9 ,DailyPrice = 110099, Description = "Sport" ,ModelYear = "2021" },
                new Car{CarId = 4 ,BrandId = 1 , ColorId = 7 ,DailyPrice = 90099, Description = "Jip" ,ModelYear = "2013" },
                new Car{CarId = 3 ,BrandId = 1 , ColorId = 6 ,DailyPrice = 100099, Description = "classic" ,ModelYear = "1965" },
            };

        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c => c.CarId == car.CarId);

            _car.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByBrand(int brandId)
        {
            return _car.Where(c => c.BrandId == brandId).ToList();
        }

        public List<Car> GetByColor(int colorId)
        {
            return _car.Where(c => c.ColorId == colorId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;


        }
    }
}

