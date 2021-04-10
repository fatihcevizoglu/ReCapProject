using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    interface IBrandService
    {
        List<Brand> GettAll();

        Brand GetById(int brand);
    }
}
