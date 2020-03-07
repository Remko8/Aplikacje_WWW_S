using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    public class Student: User
    {
        public Group Group { get; set; }

        public IList<Grade> Grades { get; set; }

        [NotMapped]
        public double AverageGrade => Math.Round(Grades.Average(global => (int)global.GradeValue), 1);

        [NotMapped]

        public IDictionary<string, double> AverageGradePerSubject => Grades
            .GroupBy(global => global.Subject.Name)
            .Select(global => new
            {
                SubjectName = global.Key,
                AvgGrade = Math.Round(global.Average(AverageGrade => (int)AverageGrade.GradeValue), 1)

            })
            .ToDictionary(avg => avg.SubjectName, avg => avg.AvgGrade);
    }
    
}
