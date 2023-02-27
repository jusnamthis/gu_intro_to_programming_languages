namespace Task034;
class Program
{
    // Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

    static Random rnd = new Random();

    static void Main(string[] args)
    {
        generateArrAndCountEvenElements();
    }

    static int[] generateArr(int len)
    {
        if (len < 0)
        {
            return new int[0];
        }

        var arr = new int[len];
        fillArr(arr);
        return arr;
    }

    static void fillArr(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(100, 1000);
        }
    }

    static int countEvenElementsOfArr(int[] arr)
    {
        var counter = 0;
        foreach (var num in arr)
        {
            if (num % 2 == 0)
            {
                counter++;
            }
        }
        return counter;
    }

    static void generateArrAndCountEvenElements()
    {
        var arr = generateArr(10);
        Console.WriteLine("[{0}]", string.Join(", ", arr));
        var amountOfEvenNumsInArr = countEvenElementsOfArr(arr);
        Console.WriteLine("{0}", amountOfEvenNumsInArr);
    }
}
