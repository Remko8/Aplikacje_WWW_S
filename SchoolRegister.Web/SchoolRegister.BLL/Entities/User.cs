
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    public abstract class User : IdentityUser<int>
    {

        /*
        protected User(string firstName, string lastName, DateTime register)
        {
            FirstName = firstName;
            LastName = lastName;
            RegistrationDate = register;
        }
        */
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime RegistrationDate { get; set; }
        

    }
}
