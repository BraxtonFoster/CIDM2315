using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the value of N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        
        for (int i = 1; i <= N; i++)
        {
            for (int j = 1; j <= N; j++)
            {
                
                Console.Write("* ");
            }
            Console.WriteLine(); 
        }
    }
}