using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BILL.Entities
{
    class Teacher:User
    {
        public IList<Subject> Subjects;
        public string Title;

        public IList<Subject> subjects
        {
            get { return Subjects; }
            set { Subjects = value; }
        }
        public string title
        {
            get { return Title; }
            set { Title = value; }
        }
    }


}
