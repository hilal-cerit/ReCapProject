using Entities.Concrete;
using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Business.ValidatorRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("User name is required.");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email is required.");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Invalid email format.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is required.");


            //    RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Please confirm your password.");

            //if (!(password.Contains("@") || password.Contains("#") 
            //         || password.Contains("!") || password.Contains("~") 
            //         || password.Contains("$") || password.Contains("%") 
            //         || password.Contains("^") || password.Contains("&") 
            //         || password.Contains("*") || password.Contains("(") 
            //         || password.Contains(")") || password.Contains("-") 
            //         || password.Contains("+") || password.Contains("/") 
            //         || password.Contains(":") || password.Contains(".") 
            //         || password.Contains(", ") || password.Contains("<") 
            //         || password.Contains(">") || password.Contains("?") 
            //         || password.Contains("|")))  
            //     { 
            //         return false; 
            //     } 


        }
    }
}
