using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    public class Grade
    {
        public DateTime dateIssue;
        public GradeScale gradeVal;
        public Subject subj;

        public DateTime DateOfIssue
        {
            get { return dateIssue; }
            set { dateIssue = value; }
        }
        public GradeScale GradeValue
        {
            get { return gradeVal; }
            set { gradeVal = value; }
        }
        public Subject Subject
        {
            get { return subj; }
            set { subj = value; }
        }
    }
}
