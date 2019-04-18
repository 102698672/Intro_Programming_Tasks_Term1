using System;
using System.Collections.Generic;

namespace List_Task_1
{
	public class Hello
	{
		public static void Main()
		{
			int check;
			int input;
			
			List<int> numbers = new List<int>();
			numbers.Add(int.Parse(Console.ReadLine()));
			numbers.Add(int.Parse(Console.ReadLine()));
			numbers.Add(int.Parse(Console.ReadLine()));
			numbers.Add(int.Parse(Console.ReadLine()));
			numbers.Add(int.Parse(Console.ReadLine()));

			Console.WriteLine("The Numbers you have chosen have been stored, enter a number to double check");
			
			check = Convert.ToInt32(Console.ReadLine());
			
			if (numbers.Contains(check))
			{
			Console.WriteLine("The number you have chosen is part of the list");
			}
			else
			{
			Console.WriteLine("The number you have chosen is not part of the list");
			}
			Console.ReadKey();
		}
	}
}