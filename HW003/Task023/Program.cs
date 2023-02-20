namespace Task023;
class Program
{
    // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

    static void Main(string[] args)
    {
        showSequenceOfCubes();
    }

    static void showSequenceOfCubes()
    {
        var seqLimit = new Random().Next(1, 20);

        for (var i = 1; i < seqLimit; i++)
        {
            Console.Write($"{Math.Pow(i, 3)}, ");
        }
        Console.WriteLine($"{Math.Pow(seqLimit, 3)}");
    }
}
