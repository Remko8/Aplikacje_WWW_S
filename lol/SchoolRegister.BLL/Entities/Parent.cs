using System.Collections.Generic;

namespace SchoolRegister.BLL.Entities
{
    public class Parent : User
    {
        public IList<Student> Students { get; set; }
    }
}
