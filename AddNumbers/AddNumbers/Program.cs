using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace AddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int sum = 0;
            string input = "";

            do
            {
                Console.Write("Enter number: (-99 to stop) ");
                input = Console.ReadLine();
                if (!input.Equals("-99"))
                {
                    int number = 0;
                    if (int.TryParse(input, out number))
                    {
                        sum = sum + number;
                    }
                    else
                        Console.Write("Oops! Invalid number found. ");
                }
                else
                    Console.WriteLine($"Your sum is {sum}");
            }
            while (!input.Equals("-99"));

        }
    }
}
