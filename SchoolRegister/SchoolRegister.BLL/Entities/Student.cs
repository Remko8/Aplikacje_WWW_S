using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    public class Student : User
    {
		private double AverageGrade;

		public double _AverageGrade
		{
			get { return AverageGrade; }
		}

		private IDictionary<string, double> AverageGradePerSubject;

		public IDictionary<string, double> _AverageGradePerSubject
		{
			get { return AverageGradePerSubject; }
		}

		private IList<Grade> Grades;

		public IList<Grade> _Grades
		{
			get { return Grades; }
			set { Grades = value; }
		}

		private Group Group;

		public Group _Group
		{
			get { return Group; }
			set { Group = value; }
		}

	}
}
