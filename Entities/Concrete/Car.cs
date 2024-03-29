﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
   public class Car : IEntity
    {
        //Id, BrandId, ColorId, ModelYear, DailyPrice, Description
       
        [Key] 
        public int CarId { get; set; }

        public int BrandId { get; set; }

        public int ColorId { get; set; }

        public string ModelYear { get; set; }

        public decimal DailyPrice { get; set; }

        public string Description { get; set; }
    }
}
