using System;

namespace NumberGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = 21;
            int theLowerBound = 1;
            int theUpperBound = maxNumber;
            int myGuess = (theLowerBound + theUpperBound) / 2;
            bool endGame = false;
            //string guess= myGuess.ToString();

            Console.WriteLine("Pick a number between 1 and 20.");
            Console.WriteLine("Press space when you're ready!");
            Console.ReadKey();

            string input;
            do   
            {
                Console.WriteLine($"Is you number {myGuess}? Write Y if yes. Write N if no.");
                input = Console.ReadLine();
                if (input == "Y" || input == "y")
                    
                {
                    Console.WriteLine("I got your number!");
                    endGame = true;
                }
                else if (input == "N" || input == "n")
                {
                    Console.WriteLine("Is your number higher or lower? Write H if higher. Write L if lower.");
                    input = Console.ReadLine();
                    if (input == "H" || input == "h")
                    {
                        theLowerBound = myGuess;
                    }
                    if (input == "L" || input == "l")
                    {
                        theUpperBound = myGuess;
                    }
                    
                    myGuess = (theLowerBound + theUpperBound) / 2;
                }
            }
            while (!endGame);


        }
        
    }
}
