using System;
using System.Collections.Generic;

namespace SchoolPractice
{
	public class Course
	{
		public string Name { get; set; }
		public Teacher Instructor { get; set; }
		public List<Student> Students { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Course course &&
                   Name == course.Name &&
                   EqualityComparer<Teacher>.Default.Equals(Instructor, course.Instructor);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Instructor);
        }
    }
}
