using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;

namespace Business.Abstract
{
    public  interface IUserService
    {
        IDataResult<List<User>> GettAll();
        IDataResult<User> GetById(int user);

        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);

        IDataResult <List<OperationClaim>> GetClaims(User user);
        IDataResult <User> GetByMail(string email);

    }
}
