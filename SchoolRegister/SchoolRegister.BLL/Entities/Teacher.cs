using System.Collections.Generic;

namespace SchoolRegister.BLL.Entities
{
    public class Teacher : User
    {
        public IList<Subject> Subjects { get; set; }
        public string Title { get; set; }
    }
}
