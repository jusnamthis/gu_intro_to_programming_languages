// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

double[] GetTwoDimensionalArrColumnsAvg(int[,] arr)
{
    var colsAverage = new double[arr.GetLength(1)];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            colsAverage[j] += arr[i, j];
        }
    }


    Console.WriteLine("[{0}]", string.Join(", ", colsAverage));
    for (int k = 0; k < colsAverage.Length; k++)
    {
        colsAverage[k] = (double)colsAverage[k] / arr.GetLength(1);
    }

    return colsAverage;
}


var arr = GenerateAndFillArr();
PrintTwoDimensionalArr(arr);
var colsAvg = GetTwoDimensionalArrColumnsAvg(arr);
Console.WriteLine("[{0}]", string.Join(", ", colsAvg));