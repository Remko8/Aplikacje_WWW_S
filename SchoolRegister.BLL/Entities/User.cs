using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
   public class User : IdentityUser<int>
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime RegistrationDate { get; set; }
    }
}
