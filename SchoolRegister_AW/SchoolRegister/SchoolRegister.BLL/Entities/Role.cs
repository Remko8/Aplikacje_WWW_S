using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace SchoolRegister.BLL.Entities
{
    class Role : IdentityRole<int>
    {
        public Role() {}
        public Role(string name) :base(name) {}
    }
}
