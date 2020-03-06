using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    public class Student : User
    {
        //public Group Group { get; set; }

        //public IList<Grade> Grades { get; set; }

        //[NotMapped]
        //public double AverageGrade => Math.Round(Grades.Average(g => (int)g.GradeValue),1);
        //[NotMapped]
        //public IDictionary<string, double> AverageGradeSubject => Grades
        //    //.GroupBy(g => g.Subject.Name)
        //    //.Select(g => new { SubjectName = g.Key, AvgGrade = Math.Round(g.Average)})


    }
}
