using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    class Student : User
    {
        public double AverageGrade { get; set; }
        public IDictionary<string,double> AverageGradePerSubject { get; set; }
        public IList<Grade> Grades { get; set; }
        public Group Group { get; set; }
    }
}
