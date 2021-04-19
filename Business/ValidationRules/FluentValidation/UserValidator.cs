using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(c => c.UsId);
            
            RuleFor(c => c.FirstName);
            
            RuleFor(c => c.LastName);
            
            RuleFor(c => c.Email);
            
            RuleFor(c => c.Password);
          
           
        }
        

    }
}
