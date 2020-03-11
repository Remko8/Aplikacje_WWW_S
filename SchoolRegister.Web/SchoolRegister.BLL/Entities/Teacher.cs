using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    public class Teacher : User
    {
        /*
        public Teacher(string firstName,string lastName,DateTime register,IList<Subject> subjects, string title):base(firstName,lastName,register)
        {
            Subjects = subjects;
            Title = title;
        }
        */
        public IList<Subject> Subjects { get; set; }
        public string Title { get; set; }
    }

}
