using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    class SubjectGroup
    {
        public Group Group { get; set; }
        public int GroupId { get; set; }
        public Subject Subject { get; set; }
        public int SubjectId { get; set; }
    }
}
