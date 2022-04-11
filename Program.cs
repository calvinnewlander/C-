using System;


namespace ConsoleApp10
{
	class Program
	{
		static void Main(string[] args)
		{
			whileloop1 myLoop = new whileloop1();
			myLoop.tryWhileLoop(); 

			doWhileLoop1 myLoop2 = new doWhileLoop1();
			myLoop2.tryDoWhileLoop();

			/*
			Console.WriteLine("The Switch Statement");
			Console.WriteLine("''''''''''''''''''''''''");

			Console.Write("INPUT .. Enter the day of the week: ");
			int day = Convert.ToInt32(Console.ReadLine());

			if (day <= 7)
			{

				switch (day)
				{
					case 1:
						Console.WriteLine("Monday");
						break;
					case 2:
						Console.WriteLine("Tuesday");
						break;
					case 3:
						Console.WriteLine("Wednesday");
						break;
					case 4:
						Console.WriteLine("Thursday");
						break;
					case 5:
						Console.WriteLine("Friday");
						break;
					case 6:
						Console.WriteLine("Saturday");
						break;
					case 7:
						Console.WriteLine("Sunday");
						break;
					default:
						Console.WriteLine("DONE");
						break;
				}
			}
			else {
				Console.WriteLine("Please enter a valid day - from 1 to 7");
			}
			Console.WriteLine("\nHave a nice day!");
			Console.ReadKey(); */
		}
	}
}
