namespace Homework4pt3;

class Program
{
    static void Main(string[] args)
    {
        createAccount();
    }

    static bool checkAge(int birth_year)
    {
        int currentYear = 2024; 
        int age = currentYear - birth_year;
        return age >= 18;
    }

    static void createAccount()
    {
        
        Console.Write("Enter Your Username: ");
        string username = Console.ReadLine();

        Console.Write("Enter Your Password: ");
        string password1 = Console.ReadLine();

        Console.Write("Enter Your Password Again: ");
        string password2 = Console.ReadLine();

        Console.Write("Enter Your Birthyear: ");
        int birthYear = int.Parse(Console.ReadLine());

        if (!checkAge(birthYear))
        {
            Console.WriteLine("Could not Creat an Account");
            return;
        }

        if (password1 != password2)
        {
            Console.WriteLine("Worng Password");
            return;
        }

        Console.WriteLine("Account is created successfully!");
    }
}
