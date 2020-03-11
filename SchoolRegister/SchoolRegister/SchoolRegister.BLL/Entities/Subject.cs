using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    public class Subject
    {
        string Description { get; set; }
        IList<Group> Groups { get; set; }
        int Id { get; set; }
        string Name { get; set; }
        Teacher Teacher { get; set; }
    }
}
