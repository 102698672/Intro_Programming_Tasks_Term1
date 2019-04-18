using System;   
namespace Nested_Repetition_Task_1
{  
   class Program  
   {  
      static void Main(string[] args)  
      {  
      
      int count = 0;
      int Value = 0;
      while(count < 5) {
      	string x = "";
      	int Count2 = 5;
      	while(Count2 > Value){
      		x = x + "x";
      		Count2 = Count2 -1;
      	}
      	Console.WriteLine(x);
      	Value = Value +1;
      	count++;}
      	
      	Console.ReadKey();
      	
     }
   }  
 }