using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    public abstract class User : IdentityUser<int>
    {
        public string firstN, lastN;
        public DateTime registrationDate;

        public string FirstName
        {
            get { return firstN; }
            set { firstN = value; }
        }
        public string LastName
        {
            get { return lastN; }
            set { lastN = value; }
        }
        public DateTime RegistrationDate
        {
            get { return registrationDate; }
            set { registrationDate = value; }
        }
    }
}
