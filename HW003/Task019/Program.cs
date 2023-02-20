namespace Task019;
class Program
{
    // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

    static void Main(string[] args)
    {
        checkForPolindrome(23432);
    }

    static void checkForPolindrome()
    {
        var numToCheck = new Random().Next(10000, 100000);
        checkForPolindrome(numToCheck);
    }

    static void checkForPolindrome(int num)
    {
        var originNum = num;
        var reversedNum = 0;
        while (num != 0)
        {
            reversedNum = reversedNum * 10 + num % 10;
            num /= 10;
        }

        if (reversedNum == originNum)
        {
            Console.WriteLine($"The number {originNum} is polindrome");
        }
        else
        {
            Console.WriteLine($"The number {originNum} is not polindrome");
        }
    }
}
