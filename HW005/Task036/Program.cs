namespace Task036;
class Program
{
    // Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

    static Random rnd = new Random();

    static void Main(string[] args)
    {
        GenerateArrAndShowOddNumsSum();
    }

    static int[] GenerateArr(int len)
    {
        if (len < 0)
        {
            return new int[0];
        }

        var arr = new int[len];
        FillArr(arr);
        return arr;
    }

    static void FillArr(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(10, 20);
        }
    }

    static void PrintArrContent(int[] arr)
    {
        Console.WriteLine("[{0}]", string.Join(", ", arr));
    }

    static int CalculateArrOddNumsSum(int[] arr)
    {
        var sum = 0;
        foreach (var num in arr)
        {
            if (num % 2 != 0)
            {
                sum += num;
            }
        }
        return sum;
    }

    static void GenerateArrAndShowOddNumsSum()
    {
        var arr = GenerateArr(4);
        PrintArrContent(arr);
        var arrOddNumbsSum = CalculateArrOddNumsSum(arr);
        Console.WriteLine("{0}", arrOddNumbsSum);
    }
}
