namespace Task010;
class Program
{
    // Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

    static void Main(string[] args)
    {
        showSecondOfThree();
    }

    static void showSecondOfThree(int rndNum)
    {
        while (rndNum > 99)
        {
            rndNum /= 10;
        }
        Console.WriteLine($"The second digit of this number is {rndNum % 10}");
    }

    static void showSecondOfThree()
    {
        var rndNum = new Random().Next(100, 1000);
        Console.WriteLine($"The origin number is -> {rndNum}");
        showSecondOfThree(rndNum);
    }
}
