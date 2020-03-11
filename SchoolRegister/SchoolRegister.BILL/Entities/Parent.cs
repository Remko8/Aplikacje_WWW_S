using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BILL.Entities
{
    class Parent:User
    {
        public IList<Student> Students;

        public IList<Student> students
        {
            get { return Students; }
            set { Students = value; }
        }
    }
}
