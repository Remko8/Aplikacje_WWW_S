using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    abstract public class User
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime RegistrationDate { get; set; }
    }
}
