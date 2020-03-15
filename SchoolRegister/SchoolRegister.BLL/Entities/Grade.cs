using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    public class Grade
    {
		private DateTime DateOfIssue;

		public DateTime _DateOfIssue
		{
			get { return DateOfIssue; }
			set { DateOfIssue = value; }
		}

		private GradeScale GradeValue;

		public GradeScale _GradeValue
		{
			get { return GradeValue; }
			set { GradeValue = value; }
		}

		private Subject Subject;

		public Subject _Subject
		{
			get { return Subject; }
			set { Subject = value; }
		}

	}
}
