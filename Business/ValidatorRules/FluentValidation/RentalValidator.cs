using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidatorRules.FluentValidation
{
    public class RentalValidator : AbstractValidator<Rental>
    {

        public RentalValidator()
        {
            RuleFor(r => r.RentBeginDate).NotEmpty();
            
            RuleFor(r => r.RentBeginDate).GreaterThanOrEqualTo(r => r.RentReturnDate);





        }







    }
}
