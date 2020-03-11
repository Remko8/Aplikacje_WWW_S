using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SchoolRegister.BLL.Entities
{
    public class Student: User
    {
        public double AvarageGrade { get; }
        public IDictionary<string, double> AvarageGradeSubject { get; }
        public IList<Grade> Grades { get; set; }
        public Group Group { get; set; }
    }
}
