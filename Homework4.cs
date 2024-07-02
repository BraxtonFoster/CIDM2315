namespace Homework4;

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("a = ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("; b = ");
        int secondNumber = int.Parse(Console.ReadLine());

        int largestNumber = GetLargestNumber(firstNumber, secondNumber);
        Console.WriteLine($"The largest number is: {largestNumber}");
    }

    static int GetLargestNumber(int num1, int num2)
    {
        return (num1 > num2) ? num1 : num2;
    }
}
