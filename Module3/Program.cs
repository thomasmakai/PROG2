using System;

namespace Module3
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Student Joe = new Student()
			{
				name = "Joe",
				course = "itt0916",
				university = "UCN",
				email = "123124@ucn.dk",
				phonenumber = "+4523456732"
			};

			Student Dave = new Student()
			{
				name = "Dave",
				university = "UCN"
			};

			Console.WriteLine("Number of students: {0}", Student.GetNumStudents());

			Joe.StudeintInfo();
			Dave.StudeintInfo();
		}
	}
	 
}
