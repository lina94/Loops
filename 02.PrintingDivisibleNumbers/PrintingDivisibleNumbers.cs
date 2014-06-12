using System;

// 2. Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.

namespace _02.PrintingDivisibleNumbers
{
    class PrintingDivisibleNumbers
    {
        static void Main()
        {
            Console.WriteLine("Type a number N: ");
            int N = int.Parse(Console.ReadLine());

            for (int number = 1; number <= N; number++)
            {
                if (number % (7*3) != 0) // checking if the number is not divided by 7 and 3
                {
                    Console.WriteLine(number);
                }
            }

        }
    }
}
