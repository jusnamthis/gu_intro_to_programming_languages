// Задача 50. Напишите программу, которая на вход принимает индексы элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1,1 -> 9
// 1,7 -> элемента с данными индексами в массиве нет

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
            arr[i, j] = rnd.Next(10, 101);
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

int[] GetIndexesToFindElementByUser()
{
    Console.WriteLine("Enter indexes of element that you want to find: ");
    Console.Write("Enter row: ");
    var row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter column: ");
    var column = Convert.ToInt32(Console.ReadLine());

    return new int[] { row, column };
}

int FindElementByIndexes(int[] indexes, int[,] arr)
{
    var row = indexes[0];
    var column = indexes[1];

    if (
        row > arr.GetLength(0) - 1
        || column > arr.GetLength(1) - 1
        || row < 0
        || column < 0)
    {
        return -1;
    }

    return arr[row, column];
}

void PrintSearchResults(int elemWithUsersIndexes)
{
    if (elemWithUsersIndexes == -1)
        Console.WriteLine("The element with the specified indexes does not exist...");
    else
        Console.WriteLine(elemWithUsersIndexes);
}

var arr = GenerateAndFillArr();
PrintTwoDimensionalArr(arr);
var indexesToFind = GetIndexesToFindElementByUser();
var elemWithUsersIndexes = FindElementByIndexes(indexesToFind, arr);
PrintSearchResults(elemWithUsersIndexes);

