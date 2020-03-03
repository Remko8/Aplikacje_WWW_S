using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    public class Student: User
    {
        double AverageGrade { get; }
        IDictionary<string, double> AverageGradePerSubject { get; }
        IList<Grade> Grades { get; set; }
        Group Group { get; set; }
    }
}
