namespace Homework3;

using System;

class Program
{
    static void Main()
    {
        Console.Write("input a integer: ");
        int N = Convert.ToInt32(Console.ReadLine());

        bool isPrime = CheckPrime(N);

        if (isPrime)
        {
            Console.WriteLine($"{N} is prime");
        }
        else
        {
            Console.WriteLine($"{N} is non-prime");
        }
    }

    
    static bool CheckPrime(int number)
    {
        
        if (number <= 1)
        {
            return false; 
        }
        if (number == 2)
        {
            return true; 
        }
        if (number % 2 == 0)
        {
            return false; 
        }

        
        int limit = (int)Math.Sqrt(number);
        for (int i = 3; i <= limit; i += 2)
        {
            if (number % i == 0)
            {
                return false; 
            }
        }

        return true; 
    }
}

