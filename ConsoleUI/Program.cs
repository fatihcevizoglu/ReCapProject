using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;


namespace ConsoleUI
{
   public class Program
    {
        static void Main(string[] args)
        {
            CarTest();
           AddMethod();

        }

        private static void AddMethod()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { BrandId = Convert.ToInt32(Console.ReadLine()), ColorId = Convert.ToInt32(Console.ReadLine()), DailyPrice = Convert.ToInt32(Console.ReadLine()), ModelYear = Console.ReadLine(), Description = Console.ReadLine() });
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("{0} ---- {1} ---- {2} ---- {3}", Convert.ToString(car.CarId),car.BrandName , car.ColorName,car.DailyPrice);
            }


        }
    }
}
