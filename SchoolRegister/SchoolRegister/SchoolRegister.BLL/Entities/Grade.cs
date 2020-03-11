using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    public class Grade
    {
        DateTime DateOfIssue { get; set; }
        GradeScale GradeValue { get; set; }
        Subject Subject { get; set; }
    }
}
