using System;

namespace ConsoleApp10
{
	class doWhileLoop1
	{
		public void tryDoWhileLoop()
		{
			Console.WriteLine("DO WHILE LOOP");
			Console.WriteLine("INPUT:");

			Console.Write("Enter a number to start: ");
			int numA = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter a number to end: ");
			int numB = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("OUTPUT:");

			int i = numA;
			do
			{
				Console.WriteLine("\nWHILE LOOP BLACK STARTS with value: " + i);
				i++;
				Console.WriteLine("Value after incrementing: " + i);
				Console.WriteLine("..WHILE LOOP BLOCK ENDS");
			}
			while (i <= numB);

			Console.WriteLine("**Thank You**");

			Console.ReadKey();
		}
	}
}
