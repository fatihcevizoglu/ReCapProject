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
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.DailyPrice);
            }



            carManager.Add(new Car { BrandId = Convert.ToInt32(Console.ReadLine()), ColorId = Convert.ToInt32(Console.ReadLine()), DailyPrice = Convert.ToInt32(Console.ReadLine()), ModelYear = Console.ReadLine(), Description = Console.ReadLine() }); 
         

        }
    }
}
