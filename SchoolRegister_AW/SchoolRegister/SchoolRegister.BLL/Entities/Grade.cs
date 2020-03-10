using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    class Grade
    {
        public DateTime DataOfIssue { get; set; }
        public GradeScale GradeValue { get; set; }
        public Subject Subject { get; set; }
    }
}
