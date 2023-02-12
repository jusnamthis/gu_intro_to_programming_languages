namespace Task002;
class Program
{
    /*
    * Напишите программу, которая на вход принимает два числа и выдаёт, 
    * какое число большее, а какое меньшее.
    */

    static void Main(string[] args)
    {
        ShowTheLargerOfTwo();
    }

    static void ShowTheLargerOfTwo()
    {
        Console.Write("Enter the first number: ");
        var a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        var b = Convert.ToInt32(Console.ReadLine());

        ShowTheLargerOfTwo(a, b);
    }

    static void ShowTheLargerOfTwo(int a, int b)
    {
        if (a > b)
        {
            Console.WriteLine("The value {0} is greater than {1}", a, b);
        }
        else
        {
            Console.WriteLine("The value {0} is greater than {1}", b, a);
        }
    }
}
