﻿using System;


namespace ConsoleApp4
{
	class Program
	{
		static void Main(string[] args)
		{
			int myNum = -2;
			Console.WriteLine("Enter number to test = " + myNum);
			Console.Write("Enter the number you want to multiply " + myNum + " with: "  );
			Console.ReadLine();

			Console.WriteLine("Using multiplication Assignment Operator...");
			myNum *= 6;

			Console.WriteLine("Updated Value of your test number =  " +myNum);

			Console.ReadKey();
		}
	}
}
