// Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
//
// Например, задан массив:
//      1 4 7 2
//      5 9 2 3
//      8 4 2 4
//
// В итоге получается вот такой массив:
//      7 4 2 1
//      9 5 3 2
//      8 4 4 2

Random rnd = new Random();

int[,] GenerateArray(int rows, int columns)
{
    return new int[rows, columns];
}

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(1, 10);
        }
    }
}

void PrintTwoDimensionalArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write("{0} ", arr[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] GenerateAndFillArr()
{
    var rows = rnd.Next(3, 5);
    var columns = rnd.Next(3, 6);
    var arr = GenerateArray(rows, columns);
    FillArray(arr);
    return arr;
}

void SortTwoDimensionalArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = arr.GetLength(1) - 1; k > j; k--)
            {
                if (arr[i, k] > arr[i, k - 1])
                {
                    var temp = arr[i, k - 1];
                    arr[i, k - 1] = arr[i, k];
                    arr[i, k] = temp;
                }
            }
        }
    }
}

var arr = GenerateAndFillArr();
PrintTwoDimensionalArr(arr);
Console.WriteLine();
SortTwoDimensionalArray(arr);
PrintTwoDimensionalArr(arr);
