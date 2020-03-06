using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    public class Grade
    {
        public GradeScale GradeValue { get; set; }
        public Subject Subject { get; set; }
    }
}
