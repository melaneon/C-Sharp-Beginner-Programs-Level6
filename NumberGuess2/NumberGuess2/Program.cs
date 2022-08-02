using System;
using System.Security.Cryptography;

namespace NumberGuess
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What's the maximum number?");
            string input = Console.ReadLine();
            int.TryParse(input, out int maxNumber);

            int minNumber = 1;
            int theLowerBound = minNumber;
            int theUpperBound = maxNumber;
            int myGuess = (theLowerBound + theUpperBound) / 2;
            bool endGameLetGuess = false;
            bool endGame = false;
            string guess = myGuess.ToString();
            int theGuess;
            string input2;

            Random random = new Random();
            int randomNumber = random.Next(minNumber, maxNumber);

            Console.WriteLine("Press \"1\" to go first, \"2\" to go second:");
            string input1 = Console.ReadLine();
            if (input1 == "1")
            {
                Console.WriteLine("Ok, you go first! Good luck!");

               
                while (endGameLetGuess == false)
                {
                    Console.WriteLine("Make your guess:");
                    theGuess = Convert.ToInt32(Console.ReadLine());

                    if (theGuess != randomNumber)
                    {
                        if (theGuess < randomNumber)
                        { 
                        Console.WriteLine("Your number is too low");
                        }
                        else if (theGuess != randomNumber || theGuess > randomNumber)
                        {
                            Console.WriteLine("Your number is too high");
                        }
                        else if (theGuess > maxNumber || theGuess < 0)
                        {
                            Console.WriteLine("Not in range");
                        }
                    }
                    else 
                    {
                        Console.WriteLine("You got the number!\n\nOk, my turn then. Wish me luck!");
                        endGameLetGuess = true;
                    }
                }
                
                
                Console.WriteLine($"Pick a number between 1 and {maxNumber}.");
                Console.WriteLine("Press space when you're ready!");
                Console.ReadKey();

                
                do
                {
                    Console.WriteLine($"Is you number {myGuess}? Write Y if yes. Write N if no.");
                    input2 = Console.ReadLine();
                    if (input2 == "Y" || input2 == "y")

                    {
                        Console.WriteLine("I got your number! Thanks for the game. ");
                        endGame = true;
                    }
                    else if (input2 == "N" || input2 == "n")
                    {
                        Console.WriteLine("Is your number higher or lower? Write H if higher. Write L if lower.");
                        input2 = Console.ReadLine();
                        if (input2 == "H" || input2 == "h")
                        {
                            theLowerBound = myGuess;
                        }
                        else if (input2 == "L" || input2 == "l")
                        {
                            theUpperBound = myGuess;
                        }

                        myGuess = (theLowerBound + theUpperBound) / 2;
                    }
                }
                while (!endGame);
            }



            if (input1 == "2")
            {
                Console.WriteLine("Ok, I go first..");

                Console.WriteLine($"Pick a number between 1 and {maxNumber}.");
                Console.WriteLine("Press space when you're ready!");
                Console.ReadKey();


                do
                {
                    Console.WriteLine($"Is you number {myGuess}? Write Y if yes. Write N if no.");
                    input2 = Console.ReadLine();
                    if (input2 == "Y" || input2 == "y")

                    {
                        Console.WriteLine("I got your number! You go next then. ");
                        endGame = true;
                    }
                    else if (input2 == "N" || input2 == "n")
                    {
                        Console.WriteLine("Is your number higher or lower? Write H if higher. Write L if lower.");
                        input2 = Console.ReadLine();
                        if (input2 == "H" || input2 == "h")
                        {
                            theLowerBound = myGuess;
                        }
                        if (input2 == "L" || input2 == "l")
                        {
                            theUpperBound = myGuess;
                        }

                        myGuess = (theLowerBound + theUpperBound) / 2;
                    }
                }
                while (!endGame);

                
                while (endGameLetGuess == false)
                {
                    Console.WriteLine("Make your guess:");
                    theGuess = Convert.ToInt32(Console.ReadLine());

                    if (theGuess != randomNumber)
                    {
                        if (theGuess < randomNumber)
                        {
                            Console.WriteLine("Your number is too low");
                        }
                        else if (theGuess != randomNumber || theGuess > randomNumber)
                        {
                            Console.WriteLine("Your number is too high");
                        }
                        else if (theGuess > maxNumber || theGuess < 0)
                        {
                            Console.WriteLine("Not in range");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You got the number!\n\nThanks for the game.");
                        endGameLetGuess = true;
                    }
                }
            }


        }

    }
}
