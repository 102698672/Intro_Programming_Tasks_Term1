/*
 * Created by SharpDevelop.
 * User: 102698672
 * Date: 18/04/2019
 * Time: 3:32 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace List_Task_2
	
{
	
	public class Hello 
	
	{

    
    
    public static void Main()    {
        int check;
        
        Console.WriteLine("Please enter in 5 numbers");

        List<int> numbers = new List<int>();
        numbers.Add(int.Parse(Console.ReadLine()));
        numbers.Add(int.Parse(Console.ReadLine()));
        numbers.Add(int.Parse(Console.ReadLine()));
        numbers.Add(int.Parse(Console.ReadLine()));
        numbers.Add(int.Parse(Console.ReadLine()));

        
        
        
        Console.WriteLine("Numbers have been recorded, enter the number you wish to check");
        A:
        check = int.Parse(Console.ReadLine());
         
    
        Console.WriteLine(linearSearch(check,numbers));
        
        goto A;
            
        
    }
    
    public static int linearSearch(int searchNumber, List<int> numbers){
        
        int amountOfTimesNumberRepeated = 0;
        for(int i = 0; i < numbers.Count; i++){
            if(numbers[i] == searchNumber){ 
                amountOfTimesNumberRepeated++;
            }
        }
        
        return amountOfTimesNumberRepeated;
    }
   }
}