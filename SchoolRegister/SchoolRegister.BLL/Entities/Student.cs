﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    public class Student : User
    {
       // public double AverageGrade { get; }
      //  IDictionary<string, double> AverageGradePerSubject { get; }
        public IList<Grade> Grades { get; set; }
        public Group Group { get; set; }

        //public Student() { }

        [ForeignKey("Parent")]
        public int?  ParentID { get; set; }

        [NotMapped] //  EF ignoruje(obliczane dopiero na poziomie aplikacji)
        public double AverageGrade => Math.Round(Grades.Average(g => (int)g.GradeValue), 1);

        [NotMapped]
        public IDictionary<string, double> AverageGradePerSubject => Grades
            .GroupBy(g => g.Subject.Name)
            .Select(g => new
            {
                SubjectName = g.Key,
                AvgGrade = Math.Round (
                        g.Average(avg => (int)avg.GradeValue)
                        , 1)
            })
            .ToDictionary(avg => avg.SubjectName, avg => avg.AvgGrade);
    }
    
}
