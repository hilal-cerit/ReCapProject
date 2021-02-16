using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class User:IEntity
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //[Required(ErrorMessage = "Email is required")]
        //[RegularExpression(@"[A-Za-z0-9._%+-]+[A-Za-z0-9.-]+\.[A-Za-z] {2,4}")]
        public string Email { get; set; }

        public int Password { get; set; }






    }
}
