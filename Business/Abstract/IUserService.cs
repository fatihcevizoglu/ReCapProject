using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public  interface IUserService
    {
        IDataResult<List<User>> GettAll();

        IDataResult<User> GetById(int user);

        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
    }
}
