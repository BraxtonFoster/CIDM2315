using System;
using System.Runtime.InteropServices;

namespace Homework2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter three numbers:");

            Console.Write("Please input the first num: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please input the second num: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please input the third num: ");
            double num3 = Convert.ToDouble(Console.ReadLine());

            double smallest = FindSmallest(num1, num2, num3);

            Console.WriteLine($"The smallest value is: {smallest}");
        }

        static double FindSmallest(double a, double b, double c)
        {
            return Math.Min(Math.Min(a, b), c);
        }
    }
    }
