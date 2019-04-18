using System;

namespace Array_Task_2
{

    class Program{
        
        public static void Main(string[] args){
            
            int count = 0;
            int[] numberarray = {34, 5, 67, 1, 99, 34, 44, 78, 34, 0};
            

            int total = 0;
            count = 0;
            while(count < numberarray.Length) {
                total = total + numberarray[count];
                count++;
            }
        
            
            Console.WriteLine("Total is " + total);

            
            Console.ReadLine();
        }
    }
}