using System;

namespace Homework3
{
    class PrimeChecker
    {
        static void Main()
        {
            Console.WriteLine("Enter a integer: ");
            int N = Convert.ToInt32(Console.ReadLine());

            if (IsPrime(N))
            {
                Console.WriteLine($"{N} is prime");
            }
            else
            {
                Console.WriteLine($"{N} is non-prime");
            }
        }

        static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
