using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    public class Subject
    {
        public string descr;
        public IList<Group> groups;
        public int id;
        public string name;
        public Teacher teacher;

        public string Description
        {
            get { return descr; }
            set { descr = value; }
        }
        public IList<Group> Groups
        {
            get { return groups; }
            set { groups = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Teacher Teacher
        {
            get { return teacher; }
            set { teacher = value; }
        }
    }
}
