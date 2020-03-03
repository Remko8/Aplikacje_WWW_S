using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    public class Grade
    {
        public DateTime DateOflssue { get; set; }
        public GradeScale GradeValues { get; set; }
        public Subject Subject { get; set; }
    }
}
