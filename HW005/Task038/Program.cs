namespace Task038;
class Program
{
    // Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

    static Random rnd = new Random();

    static void Main(string[] args)
    {
        GenerateArrAndFindMaxMinDiff();
    }

    static double[] GenerateArr(int len)
    {
        if (len < 0)
        {
            return new double[0];
        }

        var arr = new double[len];
        FillArr(arr);
        return arr;
    }

    static void FillArr(double[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Math.Round(rnd.NextDouble() * 50, 2);
        }
    }

    static void PrintArrContent(double[] arr)
    {
        Console.WriteLine("[{0}]", string.Join(", ", arr));
    }

    static double CalculateDiffBetweenArrMaxMin(double[] arr)
    {
        var max = arr.Max();
        var min = arr.Min();

        return max - min;
    }

    static void GenerateArrAndFindMaxMinDiff()
    {
        var arr = GenerateArr(10);
        PrintArrContent(arr);
        var maxMinDiff = CalculateDiffBetweenArrMaxMin(arr);
        Console.WriteLine($"{maxMinDiff}");
    }
}
