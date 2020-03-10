using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    class Parent : User
    {
        public IList<Student> Students { get; set; }
    }
}
