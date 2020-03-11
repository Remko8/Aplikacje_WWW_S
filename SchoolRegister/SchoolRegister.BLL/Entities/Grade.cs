using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    public class Grade
    {
        [Key]
        public DateTime DateOfIssue { get; set; }
        public GradeScale GradeValue { get; set; }

        public Subject Subject { get; set; }

    }
}
