using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    class Student : User
    {
        double AvarageGrade { get; }
        IDictionary<string,double> AvarageGradePerSubject { get; }
        IList<Grade> Grades { get; set; }
        Group Group { get; set; }
    }
}
