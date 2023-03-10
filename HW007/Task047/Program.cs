Random rnd = new Random();

int[] GetTwoDimensionalArraySize()
{
    Console.Write("Etner the amount of rows: ");
    var rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the amount of columns: ");
    var columns = Convert.ToInt32(Console.ReadLine());

    return new int[] { rows, columns };
}

double[,] GenerateArray(int[] size)
{
    var rows = size[0];
    var columns = size[1];
    return new double[rows, columns];
}

void FillArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.NextDouble() * 100;
        }
    }
}

void PrintTwoDimensionalArr(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write("{0:0.00} ", arr[i, j]);
        }
        Console.WriteLine();
    }
}

double[,] GenerateAndFillArr()
{
    var arrSize = GetTwoDimensionalArraySize();
    var arr = GenerateArray(arrSize);
    FillArray(arr);
    return arr;
}

var arr = GenerateAndFillArr();
PrintTwoDimensionalArr(arr);

