using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    public class Subject
    {
        public string Description { get; set; }
        public IList<Group> Groups { get; set; }
        public int Id { get; set; }
        public string Names { get; set; }
        public Teacher Teacher { get; set; }
        public object Name { get; internal set; }
    }
}
