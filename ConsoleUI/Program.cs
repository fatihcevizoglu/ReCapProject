using Business.Abstract;
using Business.Concrete;
using Core.Entities.Concrete;
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
            //RentalTest();
            //CarTest();
            //   AddMethod();

            //CarManager();
            //     RentalAdd();

            // KullanıcıcEkleme();
          // RentalAdd();

        }

        

        private static void KullanıcıcEkleme()
        {
            //UserManager userManager = new UserManager(new EfUserDal());
            //var useradd = userManager.Add(new User { FirstName = "Tekin", LastName = "Köse", Email = "tekkös@gmail.com",  = "sas31as6" });
            //Console.WriteLine(useradd.Message);
        }

        private static void RentalAdd()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var resultAdd = rentalManager.Add(new Rental {Id = 13, CarId =1 ,CustomerId = 6, ReturnDate = DateTime.Now,RentDate=DateTime.Now });
            Console.WriteLine(resultAdd.Message);
        }

        private static void CarManager()
        {
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

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());

            var result = userManager.GettAll();

            foreach (var user in result.Data)
            {
                Console.WriteLine("{0}----{1}-----{2}",user.FirstName,user.LastName,user.Email );
            }
        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var resn = rentalManager.GetById(6);
            Console.WriteLine("   {0}----{1}-----{2}-----{3}-----{4}", resn.Data.Id, resn.Data.CarId, resn.Data.CustomerId, resn.Data.RentDate, resn.Data.ReturnDate);

        }



    }
}
