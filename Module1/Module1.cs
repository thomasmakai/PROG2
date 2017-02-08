using System;

namespace Module1
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// 1.4
			Console.WriteLine("My first and last names are: Thomas Makai");
			//1.5
			Console.WriteLine("The square root of 12345 is " + Math.Sqrt(12345));
			//1.6
			int[,] IntegerSequence = new int[50, 2];
			int positive = 2;
			int negative = -3;

			for (int i = 0; i < 50; i++)
			{	 
				IntegerSequence[i, 0] = positive;
				IntegerSequence[i, 1] = negative;

				positive = positive + 2;
				negative = negative - 2;
			}

			for (int i = 0; i < 50; i++)
			{
				if (i == 50) //when printing the last elements print dot "." at the end of the array
				{
					Console.Write(IntegerSequence[i, 0] + ", ");
					Console.Write(IntegerSequence[i, 1] + ".");
					break;
				}
				else
				{
					Console.Write(IntegerSequence[i, 0] + ", ");
					Console.Write(IntegerSequence[i, 1] + ", ");
				}
			}

			//1.7
			string quotation = @"The ""use"" of quotations causes problems.";
			Console.WriteLine("\n" + quotation);

			//1.8

		}
	}
}