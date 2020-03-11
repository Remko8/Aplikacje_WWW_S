using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BILL.Entities
{
    class Group
    {
        public int Id;
        public string Name;

        public int id
        {
            get { return Id; }
            set { Id = value; }
        }
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
    }
}
