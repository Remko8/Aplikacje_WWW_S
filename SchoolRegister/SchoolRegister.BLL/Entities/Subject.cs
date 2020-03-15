using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    public class Subject
    {
		private string Description;

		public string _Description
		{
			get { return Description; }
			set { Description = value; }
		}

		private int Groups;

		public IList<Group> _Groups
		{
			get { return Groups; }
			set { Groups = value; }
		}


		private int Id;

		public int _Id
		{
			get { return Id; }
			set { Id = value; }
		}

		private string Name;

		public string _Name
		{
			get { return Name; }
			set { Name = value; }
		}

		private Teacher Teacher;

		public Teacher _Teacher
		{
			get { return Teacher; }
			set { Teacher = value; }
		}


	}
}
