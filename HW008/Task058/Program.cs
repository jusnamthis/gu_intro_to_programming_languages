// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Две матрицы можно перемножить между собой тогда и только тогда, 
// когда количество столбцов первой матрицы равно количеству строк второй матрицы.

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
    Console.WriteLine();
}

int[,] GenerateAndFillArr(int rows, int columns)
{
    var arr = GenerateArray(rows, columns);
    FillArray(arr);
    return arr;
}

int[,] MultiplyTwoArrs(int[,] arrA, int[,] arrB)
{
    int[,] res = new int[arrA.GetLength(0), arrB.GetLength(1)];

    for (int i = 0; i < arrA.GetLength(0); i++)
    {
        for (int j = 0; j < arrB.GetLength(1); j++)
        {
            var sum = 0;
            for (int k = 0; k < arrA.GetLength(1); k++)
            {
                sum += arrB[k, j] * arrA[i, k];
            }
            res[i, j] = sum;
        }
    }

    return res;
}

var arr = GenerateAndFillArr(2, 3);
PrintTwoDimensionalArr(arr);
var arrB = GenerateAndFillArr(3, 2);
PrintTwoDimensionalArr(arrB);
var multMatrix = MultiplyTwoArrs(arr, arrB);
PrintTwoDimensionalArr(multMatrix);

