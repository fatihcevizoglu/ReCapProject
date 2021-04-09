using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
   public class CarDatBaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server =  (localdb)\MSSQLLocalDB; Database = CarDatBase ; Trusted_Connection = true ");
        }

        public DbSet<Car> Car { get; set; }

        public DbSet<Brand> Brand { get; set; }

        public DbSet<CarColor> CarColor { get; set; }
    }
}