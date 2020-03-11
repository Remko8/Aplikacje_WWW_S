using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BILL.Entities
{
    abstract class User: IdentityUser<int>
    {
        public string FirstName, LastName;
        public DateTime RegistrationDate;

        public string Firstname
        {
            get { return FirstName; }
            set { FirstName = value; }
        }

        public string Lastname
        {
            get { return LastName; }
            set { LastName = value; }
        }
        public DateTime Date
        {
            get { return RegistrationDate; }
            set { RegistrationDate = value; }
        }
    }
}
