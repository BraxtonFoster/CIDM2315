using System;
using System.Runtime.InteropServices;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a letter grade: ");
            char userInput = Console.ReadKey().KeyChar;
double result = LetterGradeToGPA(userInput);
if (result == -1)
{
    Console.WriteLine("\nWrong Letter Grade!");
}
else
{
    Console.WriteLine("\nGPA Point:" + result);
}
        }

        static double LetterGradeToGPA(char letterGrade)
        {
            char upperCaseGrade = char.ToUpper(letterGrade);

            if (upperCaseGrade == 'A')
              {
                  return 4.0;
              }
              else if (upperCaseGrade == 'B')
            {
                return 3.0;
            }
            else if (upperCaseGrade == 'C')
            {
                return 2.0;
            }
            else if (upperCaseGrade == 'D')
            {
                return 1.0;
            }
            else if (upperCaseGrade == 'F')
            {
                return 0.0;
            }
            else
            {
                return -1;
            }
        }
    }
}