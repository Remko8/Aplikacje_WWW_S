using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace SchoolRegister.BLL.Entities
{
    public class Role : IdentityRole<int>
    {
        public Role() { }
        public Role(string Name) : base(Name) { }
    }
}
