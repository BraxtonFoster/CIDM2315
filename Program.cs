using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a letter grade:");
            char grade = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine(); 
            int gpa;

            switch (grade)
            {
                case 'A':
                    gpa = 4;
                    break;
                case 'B':
                    gpa = 3;
                    break;
                case 'C':
                    gpa = 2;
                    break;
                case 'D':
                    gpa = 1;
                    break;
                case 'F':
                    gpa = 0;
                    break;
                default:
                    Console.WriteLine("Wrong Letter Grade!");
                    return; 
            }

            Console.WriteLine($"GPA Point: {gpa}");
        }
    }
}
