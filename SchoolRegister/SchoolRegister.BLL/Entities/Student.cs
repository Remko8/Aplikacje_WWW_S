using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SchoolRegister.BLL.Entities
{
    public class Student : User
    {
        public double AverageGrade => Math.Round(Grades.Average(g => (int)g.GradeValue), 1);
        public IDictionary<string, double> AverageGradePerSubject => Grades
            .GroupBy(g=> g.Subject.Name)
            .Select(g => new { SubjectName = g.Key,
                                AvgGrade = Math.Round(
                                    g.Average(avg => (int) avg.GradeValue)
                                    , 1)})
            .ToDictionary(avg => avg.SubjectName, avg => avg.AvgGrade);
        public IList<Grade> Grades { get; set; }
        public Group Group { get; set; }
    }
}
