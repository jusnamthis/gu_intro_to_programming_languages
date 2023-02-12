namespace Task004;
class Program
{
    // Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

    static void Main(string[] args)
    {
        ShowMaxOfThree();
    }

    static int GetNumber(int index)
    {
        Console.Write("Enter the {0} number: ", index);
        var num = Convert.ToInt32(Console.ReadLine());
        return num;
    }

    static void ShowMaxOfThree()
    {
        var a = GetNumber(1);
        var b = GetNumber(2);
        var c = GetNumber(3);
        ShowMaxOfThree(a, b, c);
    }

    static void ShowMaxOfThree(int a, int b, int c)
    {
        var max = a > b ? a : b;
        max = max > c ? max : c;
        Console.WriteLine("The {0} is the largest.", max);
    }
}
