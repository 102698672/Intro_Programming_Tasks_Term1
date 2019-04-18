using System;


namespace GuessingGame
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            int secretnumber;
            Random random = new Random();
            secretnumber = random.Next(1, 25);
            
            Console.WriteLine("Hey there! Let's play a little guessing game.");

            
            int Guessno = 7;
            
            while (Guessno != 0)
            {
                
                
                Console.WriteLine("Guess a number between 0 and 25.");
                string uinput = Console.ReadLine();
                
                int vinput = int.Parse(uinput);
                
                
                if (vinput < secretnumber) {
                    Console.WriteLine("Too low! Guess a higher value");
                    Guessno = Guessno - 1;
                    Console.WriteLine("You have " + Guessno + " guesses left!");
                } else if (vinput > secretnumber) {
                    Console.WriteLine("Too high! Guess a lower value");
                    Guessno = Guessno - 1;
                    Console.WriteLine("You have " + Guessno + " guesses left!");
                } else if (vinput == secretnumber) {
                    Console.WriteLine("Nice work! You guessed the number! " + "The secret number was: " + secretnumber);
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                
                
                
                
                
                
                
                
                
            }
            Console.WriteLine("You're all out of guesses! Thanks for playing!");
            Console.ReadKey();
        }
        
        

    }
    
}4