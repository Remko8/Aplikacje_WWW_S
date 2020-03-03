using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    public class Teacher : User
    {
        IList<Subject> Subjects { get; set; }
        string Title {get; set;}
    }
}
