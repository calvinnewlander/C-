using System;


namespace ConsoleApp10
{
	class whileloop1
	{
		public void tryWhileLoop()
		{
			Console.WriteLine("WHILE LOOP");
			Console.WriteLine("INPUT:");

			Console.Write("Enter a number to start: ");
			int numA = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter a number to end: ");
			int numB = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("\nOUTPUT:");


			int i = numA;
			while (i <= numB)
			{
				Console.WriteLine("\nWHILE LOOP BLACK STARTS with value: " + i);
				i++;
				Console.WriteLine("Value after incrementing: " + i);
				Console.WriteLine("..WHILE LOOP BLOCK ENDS");
			}

			Console.WriteLine("**Thank You**");

			Console.ReadKey();
		}
	}
}
