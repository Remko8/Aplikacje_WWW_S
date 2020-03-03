using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    public class Group: IdentityUser<int>
    {
        int Id { get; set; }
        string Name { get; set; }
    }
}
