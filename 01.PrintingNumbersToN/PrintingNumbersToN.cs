using System;

// 1. Write a program that prints all the numbers from 1 to N.

namespace PrintingNumbersToN
{
    class PrintingNumbersToN
    {
        static void Main(string[] args)
        {
            string input;
            int N;

            // checking if the input is correct
            do
            {
                Console.WriteLine("Type a number N: ");
                input = Console.ReadLine();
            }
            while (!int.TryParse(input, out N) || (N <= 0)); 

            // printing the numbers
            for (int counter = 1; counter <= N; counter++)
            {
                Console.WriteLine(counter);
            }
        }
    }
}
