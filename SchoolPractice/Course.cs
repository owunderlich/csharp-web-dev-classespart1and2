using System;
using System.Collections.Generic;

namespace SchoolPractice
{
	public class Course
	{
		public string Name { get; set; }
		public List<Teacher> Teachers { get; set; }
		public List<Student> Students { get; set; }
	}
}
