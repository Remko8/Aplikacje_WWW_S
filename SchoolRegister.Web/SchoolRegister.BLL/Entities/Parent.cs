using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
   public class Parent:User
    {
        /*
        public Parent(string firstName, string lastName, DateTime register, IList<Student> students) : base(firstName, lastName, register)
        {
            Students = students;
        }
        */
        public IList<Student> Students { get; set; }
    }
}
