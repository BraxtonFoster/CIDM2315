namespace Homework4pt2;

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("a = ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("; b = ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.Write("; c = ");
        int thirdNumber = int.Parse(Console.ReadLine());

        Console.Write("d = ");
        int fourthNumber = int.Parse(Console.ReadLine());


        int largestNumber = GetLargestNumber(firstNumber, secondNumber, thirdNumber, fourthNumber);
        Console.WriteLine($"The largest number is: {largestNumber}");
    }

    static int GetLargestNumber(int num1, int num2, int num3, int num4)
    {
        int max1 = (num1 > num2) ? num1 : num2;   
        int max2 = (num3 > num4) ? num3 : num4;   

        return (max1 > max2) ? max1 : max2;       
    }
}
