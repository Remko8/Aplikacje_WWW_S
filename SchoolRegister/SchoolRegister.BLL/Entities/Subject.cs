using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    public class Subject
    {
        public string Description { get; set; }
        public List<Group> Groups { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public Teacher Techer { get; set; }
    }
}
