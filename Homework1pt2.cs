using System;

namespace Homework1pt2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter three numbers:");

            Console.Write("Number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number 3: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int smallest = num1;

            if (num2 < smallest)
            {
                smallest = num2;
            }

            if (num3 < smallest)
            {
                smallest = num3;
            }

            Console.WriteLine($"The smallest number is: {smallest}");
        }
    }
}

