using System;

namespace Homework3
{
    class SquarePattern
    {
        static void Main()
        {
            Console.Write("Assign an in value to N: ");
            int N = Convert.ToInt32(Console.ReadLine());

            if (N > 0)
            {
                for (int i = 1; i <= N; i++)
                {
                    for (int j = 1; j <= N; j++)
                    {
                        Console.Write("* ");
                    }

                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Please enter a positive integer for N.");
            }
        }
    }
}
