using System;


namespace ConsoleApp6
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("The 'If' Statement");
			Console.WriteLine("'''''''''''''''''''");

			Console.WriteLine("Enter 1st number: ");
			int numA = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter 2nd number: ");
			int numB = Convert.ToInt32(Console.ReadLine());

			Boolean conditionResult = numA > numB;
			Console.WriteLine("\nCondition Result = " + conditionResult);

			if (conditionResult == true) {
				Console.WriteLine("\n1st number is greater than 2nd number");
				Console.WriteLine(numA + " is greater than " + numB);
			}

			if (conditionResult == false) {
				Console.WriteLine("\n1st number is not greater than 2nd number");
				Console.WriteLine(numA + " is not greater than " + numB);
			} 

			Console.WriteLine("''''''''''Thank you!''''''''''''");

			Console.ReadLine();
		}
	}
}
