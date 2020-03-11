using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    public class Student:User
    {

        /*
        public Student(string firstName, string lastName, DateTime register, double averageGrade, IDictionary<string, double> averageGradePerSubject, IList<Grade> grades, Group group): base(firstName, lastName, register)
        {
            AverageGrade = averageGrade;
            AverageGradePerSubject = averageGradePerSubject;
            Grades = grades;
            Group = group;
        }
        */
        public double AverageGrade { get; set; }
        public IDictionary<string,double> AverageGradePerSubject { get; set; }
        public IList<Grade> Grades { get; set; }
        public Group Group { get; set; }

    }
}
