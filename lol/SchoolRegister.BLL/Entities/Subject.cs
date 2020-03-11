using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolRegister.BLL.Entities
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public IList<Group> Groups { get; set; }

        public Teacher Teacher { get; set; }
    }
}
