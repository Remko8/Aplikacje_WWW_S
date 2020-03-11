using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BILL.Entities
{
    class Student:  User
    {
        public double AverageGrade;
        public IDictionary<string, double> AverageGradeSubject;
        public IList<Grade> Grades;
        public Group Group;

        public double Averagegrade
        {
            get { return AverageGrade; }
        }
        public IDictionary<string,double> Averagegradesubject
        {
            get { return AverageGradeSubject; }
        }
        public IList<Grade> grades
        {
            get { return Grades; }
            set { Grades = value; }
        }
        public Group group
        {
            get { return Group; }
            set { Group = value; }
        }
    }
}
