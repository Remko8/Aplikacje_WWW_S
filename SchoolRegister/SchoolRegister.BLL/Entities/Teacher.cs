using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    class Teacher:User
    {
        IList<Subject> Subject { get; set; }
        string Title { get; set; }
    }
}
