namespace Task013;
class Program
{
    // Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

    static void Main(string[] args)
    {
        showThirdDigit();
    }

    static void showThirdDigit(int rndNum)
    {
        var thirdDigit = -1;
        while (rndNum > 999)
        {
            rndNum /= 10;
        }

        thirdDigit = rndNum <= 999 && rndNum >= 100 ? rndNum % 10 : thirdDigit;

        if (thirdDigit >= 0)
        {
            Console.WriteLine($"The third digit of origin number is -> {thirdDigit}");
        }
        else
        {
            Console.WriteLine($"Seems like there is no third digit on origin number...");
        }
    }

    static void showThirdDigit()
    {
        var rndNum = new Random().Next(10, 100000);
        Console.WriteLine($"The origin number is -> {rndNum}");
        showThirdDigit(rndNum);
    }
}
