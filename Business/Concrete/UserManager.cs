﻿using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
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

       // [SecuredOperation("user.add,admin")]
        [ValidationAspect(typeof(UserValidator))]
        public IResult Add(User user)
        {
            _userDal.Add(user);

            return new SuccessResult(Messages.CarAdded);
        }

        [ValidationAspect(typeof(UserValidator))]
        public IResult Delete(User user)
        {
            _userDal.Delete(user);

            return new SuccessResult(Messages.CarDeleted);

        }

        public IDataResult<User> GetById(int user)
        {
            return new SuccessDataResult<User>(_userDal.Get(c => c.Id == user));
        }

        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
           
            return new SuccessDataResult<List<OperationClaim>>(_userDal.GetClaims(user));
        }

        public IDataResult<List<User>> GettAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.CarListed);
        }

        [ValidationAspect(typeof(UserValidator))]
        public IResult Update(User user)
        {
            _userDal.Update(user);

            return new SuccessResult(Messages.CarUpdated);

        }

        public IDataResult<User> GetByMail(string email)
        {
            return new SuccessDataResult<User> (_userDal.Get(u => u.Email == email));
        }

    }
}
