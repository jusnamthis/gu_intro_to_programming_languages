namespace Task006;
class Program
{
    /* Напишите программу, которая на вход принимает число и выдаёт, 
    является ли число чётным (делится ли оно на два без остатка). */

    static void Main(string[] args)
    {
        IsNumEven();
    }

    static void IsNumEven()
    {
        Console.Write("Enter the number: ");
        var x = Convert.ToInt32(Console.ReadLine());
        IsNumEven(x);
    }

    static void IsNumEven(int x)
    {
        if (x % 2 == 0)
        {
            Console.WriteLine("The number is even.");
        }
        else
        {
            Console.WriteLine("The number is uneven.");
        }
    }
}
