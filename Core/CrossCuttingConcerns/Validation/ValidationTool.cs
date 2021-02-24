using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Validation
{
   public static class ValidationTool//<T entity>
    {
        public static void Validate(IValidator validator,object entity)
        {
            var context = new ValidationContext<object>(entity);//baseler object
        
            var result =validator.Validate(context);
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }



        }
    }
}
