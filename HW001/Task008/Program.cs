namespace Task008;
class Program
{
    /*
    * Напишите программу, которая на вход принимает число (N), 
    * а на выходе показывает все чётные числа от 1 до N.
    */

    static void Main(string[] args)
    {
        ShowEvenNumbsInRange();
    }

    static void ShowEvenNumbsInRange()
    {
        Console.Write("Enter the top of range: ");
        var topOfRange = Convert.ToInt32(Console.ReadLine());
        ShowEvenNumbsInRange(topOfRange);
    }

    static void ShowEvenNumbsInRange(int topOfRange)
    {
        if (topOfRange <= 0)
        {
            Console.WriteLine("Wrong top of range!");
            return;
        }

        for (var i = 1; i <= topOfRange; i++)
        {
            if (i % 2 == 0)
                Console.Write(i + " ");
        }
    }
}
