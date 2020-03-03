using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
namespace SchoolRegister.BLL.Entities
{
    public class User : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public DateTime RegistrationDate{get;set;}



    }
}
