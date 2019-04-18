
using System;

namespace Array_Task_1
{

	class Program
	{
        
		public static void Main(string[] args)
		{
            
			int count = 0;
			string[] namesArray = new string[5];
              
			while (count < namesArray.Length) {
				string name = Console.ReadLine();
				namesArray[count] = name;
				count++;
			}
            
			count = 0;
			while (count < namesArray.Length) {
				string name = namesArray[count];
				Console.WriteLine("Hello " + name);
				count++;
			}
            
			Console.ReadLine();
		}
	}
}