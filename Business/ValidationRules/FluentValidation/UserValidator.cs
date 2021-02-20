using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x => x.Email).NotEmpty();
            RuleFor(x => x.Password).NotEmpty();
            RuleFor(x => x.Password).Must(ValidatePassword);
          
        }
        
        private bool ValidatePassword(string arg)
        {
            const int minPassword = 8;
            var password = arg.ToLower();
          
            if (password == null)
            {
                throw new ArgumentNullException();
            }
            return password.Length >= minPassword;
            
            
        }
    }
}
