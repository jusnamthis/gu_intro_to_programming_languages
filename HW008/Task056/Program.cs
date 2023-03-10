// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов:
// 1 строка

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
    var rows = rnd.Next(5, 7);
    var columns = rnd.Next(3, 5);
    var arr = GenerateArray(rows, columns);
    FillArray(arr);
    return arr;
}

int FindRowWithMaxElemsSumInTwoDimArr(int[,] arr)
{
    int maxSum = 0;
    int maxRow = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int currentRowSum = 0;

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            currentRowSum += arr[i, j];
        }

        if (currentRowSum > maxSum)
        {
            maxSum = currentRowSum;
            maxRow = i;
        }
    }

    return maxRow;
}

var arr = GenerateAndFillArr();
PrintTwoDimensionalArr(arr);
Console.WriteLine();
var maxRow = FindRowWithMaxElemsSumInTwoDimArr(arr);
Console.WriteLine(maxRow);