using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
   public class Student : User
    {
        [NotMapped]
        public double AverageGrade => Math.Round(Grades
            .Average(g => (int)g.GradeValue), 1);
        [NotMapped]
        public IDictionary<string, double> AverageGradePerSubject => Grades
             .GroupBy(g => g.Subject.Name)
             .Select(g => new {
                 SubjectName = g.Key,
                     AvgGrande = Math.Round(
                          g.Average(AverageGrade => (int)AverageGrade.GradeValue), 1
                          )
                })
            .ToDictionary(AverageGrade => AverageGrade.SubjectName, AverageGrade => AverageGrade.AvgGrande);
        public IList<Grade> Grades { get; set; }
        public Group Group { get; set; }
        [ForeignKey("Group")]
        public int GruopId { get; set; }

        public IList<Student> Students { get; set; }


      
    }
}
