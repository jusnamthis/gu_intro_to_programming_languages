// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

var rnd = new Random();

void GetNumberAndPushItToArr(int arrIndex, int[] arr)
{
    var n = rnd.Next(1, 100);
    arr[arrIndex] = n;
}

void PrintArr(int[] arr)
{
    foreach (var el in arr)
    {
        Console.Write($"{el} ");
    }
}

int[] arr = new int[8];
for (int i = 0; i < arr.Length; i++)
{
    GetNumberAndPushItToArr(i, arr);
}

PrintArr(arr);
