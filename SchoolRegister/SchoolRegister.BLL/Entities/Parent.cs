using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    public class Parent : User
    {
		private IList<Student> Students;

		public IList<Student> _Students
		{
			get { return Students; }
			set { Students = value; }
		}

	}
}
