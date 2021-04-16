﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public class UserManager : IUserService
    {
        IUserDal  _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            _userDal.Add(user);

            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);

            return new SuccessResult(Messages.CarDeleted);

        }

        public IDataResult<User> GetById(int user)
        {
            return new SuccessDataResult<User>(_userDal.Get(c => c.UsId == user));
        }

        public IDataResult<List<User>> GettAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.CarListed);
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);

            return new SuccessResult(Messages.CarUpdated);

        }
    }
}
