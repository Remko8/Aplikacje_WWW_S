using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
     public class Student : User 
    {
        public double AverageGrade { get; }
        public IDictionary<string,double> AverageGradePerSubject { get; set; }
        public IList<Grade> Grade { get; set; }
        public Grade Group { get; set; }
    }
}
