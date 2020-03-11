using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
   public class Grade
    {
        public DateTime DateOfIssue { get; set; }
        public GradeScale GradeScale { get; set; }
        public Subject Subject { get; set; }
        /*
        public Grade(DateTime dateOfIssue, GradeScale gradeScale, Subject subject)
        {
            DateOfIssue = dateOfIssue;
            GradeScale = gradeScale;
            Subject = subject;
        }
        */
    }
}
