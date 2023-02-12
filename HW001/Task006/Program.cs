namespace Task006;
class Program
{
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
