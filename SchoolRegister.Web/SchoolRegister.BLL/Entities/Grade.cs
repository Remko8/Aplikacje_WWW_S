using System;
namespace SchoolRegister.BLL.Entities
{
    public class Grade
    {
        public DateTime DateOfIssue { get; set; }
        public GradeScale GradeValue { get; set; }
        public Subject Subject { get; set; }
    }
}