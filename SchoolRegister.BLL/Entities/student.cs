using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    public class Student:User
    {
        public double AvergaeGrade { get; }
        public IDictionary<string,double> AverageGradePerSubjcet { get; }
        public IList<Grade> Grades { get; set; }
        public Group Group { get; set; }
    }
}
