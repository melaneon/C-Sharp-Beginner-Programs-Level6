using System;
using System.Dynamic;
using System.Net.Mail;

namespace BoxMaker
{
    class Program
    {
        
        static void Main(string[] args)
        {
            char boxChar;
            int boxSize=0;

            Console.WriteLine("Enter the character.");
            string line = Console.ReadLine();
            char.TryParse(line.Substring(0, 1), out boxChar);

            Console.WriteLine("Enter the box size.");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int num))
            {
                if (num != 0)
                    {
                    boxSize = num;
                }
                else 
                    {

                    Console.WriteLine("Ooops, looks like the number you entered: 0, is not accepltable. Please, try again");
                }
            }
            else
            {
                Console.WriteLine(input, "Ooops, looks like the number you entered: {0}, is not accepltable. Please, try again");
            }


            Console.WriteLine("Here is your box.");
            DisplayTask(boxSize, boxChar);

            Console.ReadLine();

            


            Console.ReadKey();
            
        }
        static void DisplayTask(int boxSize, char boxChar)
        {

            for (int r = 1; r <= boxSize; r++)
            {
                for (int c = 1; c <= boxSize; c++)
                {
                    Console.Write(boxChar);
                }
                Console.WriteLine();
            }
        }

    }
}
