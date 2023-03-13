// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int FindNaturElementsSumInRange(int m, int n)
{
    if (m > n)
        return 0;

    return m + FindNaturElementsSumInRange(++m, n);
}

var sum = FindNaturElementsSumInRange(4, 8);
Console.WriteLine("{0}", sum);