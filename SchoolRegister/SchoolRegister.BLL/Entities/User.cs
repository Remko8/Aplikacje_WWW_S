using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    class User : IdentityUser<int>
    {
        public string FirtName { get; set; }
        public string LastName { get; set; }

        public DateTime RegisrtationDate { get; set; }
    }
}
