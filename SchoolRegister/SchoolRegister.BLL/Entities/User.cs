using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace SchoolRegister.BLL.Entities
{
    public abstract class User : IdentityUser<int>
    {
        private string FirstName;
        public string _FirstName
        {
            get { return FirstName; }
            set { FirstName = value; }
        }

        private string LastName;
        public string _LastName
        {
            get { return LastName; }
            set { LastName = value; }
        }

        private DateTime RegistrationDate;
        public DateTime _RegistrationDate
        {
            get { return RegistrationDate; }
            set { RegistrationDate = value; }
        }



    }
}
