using Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidatorRules.FluentValidation
{
  public  class CarValidator:AbstractValidator<Car>

    {
        public CarValidator()
        {
            RuleFor(p => p.CarName).MinimumLength(2);
            RuleFor(p => p.CarName).NotEmpty();
            RuleFor(p => p.DailyPrice).GreaterThan(0);
            RuleFor(p => p.DailyPrice).GreaterThanOrEqualTo(0).When(p=>p.CarId==1);
            RuleFor(p => p.CarName).Must(StartWithA).WithMessage("hello");


        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("a");
        }
    }

}
