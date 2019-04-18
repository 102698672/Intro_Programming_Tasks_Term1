/*
 * Created by SharpDevelop.
 * User: 102698672
 * Date: 18/04/2019
 * Time: 3:48 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Nested2  
	
{  
	
   class Program  
   	
   {  
   	
      static void Main(string[] args)  
      	
      {  
      	
      Console.WriteLine("How many line do you want?");
      string uinput = Console.ReadLine();
      	
      	
         //int val = 5;
         int vinput;
         vinput = int.Parse(uinput);
       
	   int val = vinput;         
         int i, j, k ;  
         for (i = 1; i <= val; i++)  
         {  
            for (j = 1; j <= i; j++)  
            {  
               Console.Write("");  
            }  
            for (k = 1; k <= i; k++)  
            {  
               Console.Write("*");  
            }  
            Console.WriteLine("");  
         }  
         Console.ReadLine();  
      }  
   }  
} 