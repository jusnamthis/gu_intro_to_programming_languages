namespace Task025;
class Program
{

    // Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

    static void Main(string[] args)
    {
        GetNumbersAndRaise();
    }

    static int GetNumber(string message)
    {
        Console.Write(message);
        var num = Convert.ToInt32(Console.ReadLine());
        return num;
    }

    static void GetNumbersAndRaise()
    {
        var m = GetNumber("Enter the number M to raise to the power of N: ");
        var n = GetNumber("Enter the power N: ");
        var res = m;

        for (var i = 1; i < n; i++)
        {
            res *= m;
        }

        if (n == 0)
        {
            res = 1;
        }

        Console.WriteLine($"The number {m} to the power of {n} is: {res}");
    }
}
