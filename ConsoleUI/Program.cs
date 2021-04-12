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
            //  CarTest();
            //   AddMethod();

            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarId + " / " + car.BrandName + " / " + car.ColorName + " / " + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }

        private static void AddMethod()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { BrandId = Convert.ToInt32(Console.ReadLine()), ColorId = Convert.ToInt32(Console.ReadLine()), DailyPrice = Convert.ToInt32(Console.ReadLine()), ModelYear = Console.ReadLine(), Description = Console.ReadLine() });
        }

        private static void CarTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var brand in brandManager.GettAll())
            {
                Console.WriteLine("{0} ---- {1}", Convert.ToString(brand.BrandId),brand.BrandName );
            }
        }

        

    }
}
