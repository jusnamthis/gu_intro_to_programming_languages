namespace Task027;
class Program
{

    // Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

    static void Main(string[] args)
    {
        GetNumberAndCalculateSumOfItsDigits();
    }

    static int GetNumber(string message)
    {
        Console.Write(message);
        var num = Convert.ToInt32(Console.ReadLine());
        return num;
    }

    static void GetNumberAndCalculateSumOfItsDigits()
    {
        var num = GetNumber("Enter the number to calculate sum of its digits: ");
        var res = 0;

        while (num > 0)
        {
            res += num % 10;
            num /= 10;
        }

        Console.WriteLine($"{res} is a sum of your digits");
    }
}
