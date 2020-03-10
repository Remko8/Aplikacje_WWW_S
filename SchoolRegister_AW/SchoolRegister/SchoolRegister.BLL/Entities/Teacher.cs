using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    class Teacher : User
    {
        public IList<Subject> Subjects { get; set; }
        public string Title { get; set; }
    }
}
