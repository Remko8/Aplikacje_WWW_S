using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    public class Student : User
    {
        public double avgGrade;
        public IDictionary<string, double> avgGradePerSubj;
        public IList<Grade> grades;
        public Group group;

        public double AverageGrade{
            get { return avgGrade; }
        }
        public IDictionary<string, double> AverageGradePerSubject
        {
            get { return avgGradePerSubj; }
        }
        public IList<Grade> Grades
        {
            get { return grades; }
        }
        public Group Group
        {
            get { return group; }
        }
    }
}
