using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    class Parent:User
    {
        IList<Student> Students { get; set; }
    }
}
