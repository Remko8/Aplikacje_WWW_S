using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    public class Parent : User
    {
        public List<Student> Students { get; set; }
    }
}
