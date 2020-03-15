using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    public class Teacher : User
    {
		private IList<Subject> Subjects;

		public IList<Subject> _Subjects
		{
			get { return Subjects; }
			set { Subjects = value; }
		}

		private string Title;

		public string _Title
		{
			get { return Title; }
			set { Title = value; }
		}

	}
}
