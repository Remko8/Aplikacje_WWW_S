using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    class Role:IdentityRole<int>
    {
        public Role()
        {

        }
        public Role(string name)
        {

        }
    }
}
