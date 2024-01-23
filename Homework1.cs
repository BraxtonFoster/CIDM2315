using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;

namespace Homework1;

class Program
{
    static void Main(string[] args)
    {
        double X = 2.5;
        double Y = 3.3;
        double Z = 4*X*X + 3 * Y;
        Console.WriteLine("X = "+X+ ", Y = "+Y);
        Console.WriteLine("THe Value of Z is: "+Z);

    }
}
