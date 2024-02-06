using System;

namespace Homework3
{
    class SquarePattern
    {
        static void Main()
        {
            Console.Write("Enter the number of rows (N): ");
            int N = Convert.ToInt32(Console.ReadLine());

            if (N > 0)
            {
                PrintRepeatingNumberSquarePattern(N);
            }
            else
            {
                Console.WriteLine("Please enter a positive integer for N.");
            }
        }

        static void PrintRepeatingNumberSquarePattern(int rows)
        {
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
