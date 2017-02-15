using System;
namespace Module3
{
	class Student
	{
		public string name;
		public string course;
		public string university;
		public string email;
		public string phonenumber;

		public Student()
		{
			name = null;
			course = null;
			university = null;
			email = null;
			phonenumber = null;
			numOfStudents++;
		}

		public Student(string name = null, string course = null, string university = null, string email = null, string phonenumber = null)
		{
			this.name = name;
			this.course = course;
			this.university = university;
			this.email = email;
			this.phonenumber = phonenumber;
			numOfStudents++;
		}

		public Student(string name = null, string course = null, string university = null, string email = null)
		{
			this.name = name;
			this.course = course;
			this.university = university;
			this.email = email;
			this.phonenumber = null;
			numOfStudents++;
		}

		public Student(string name = null, string course = null, string university = null)
		{
			this.name = name;
			this.course = course;
			this.university = university;
			this.email = null;
			this.phonenumber = null;
			numOfStudents++;
		}

		public Student(string name = null, string course = null)
		{
			this.name = name;
			this.course = course;
			this.university = null;
			this.email = null;
			this.phonenumber = null;
			numOfStudents++;
		}

		public Student(string name = null)
		{
			this.name = name;
			this.course = null;
			this.university = null;
			this.email = null;
			this.phonenumber = null;
			numOfStudents++;
		}

		public void StudeintInfo()
		{
			Console.WriteLine("Name: {0}", name);
			Console.WriteLine("Course: {0}", course);
			Console.WriteLine("University: {0}", university);
			Console.WriteLine("Email: {0}", email);
			Console.WriteLine("Phone: {0}", phonenumber);
			Console.WriteLine(" ");
		}

		static int numOfStudents = 0;

		public static int GetNumStudents() 
		{
			return numOfStudents; 
		}

		/*TO DO
		 * set variables to private
		 * Set and Get methods for variables
		 * http://www.newthinktank.com/2017/01/c-tutorial-5/
		 */

	}
}
