using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    public class SubjectGroups
    {
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }

    }
}
