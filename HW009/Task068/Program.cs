// Задайте значения M и N. Напишите программу, 
// которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.
// M = 28; N = 7 -> 7

int FindGreatestCommonDivisor(int m, int n, int div)
{
    if (div == 1)
        return div;

    if (m % div == 0 && n % div == 0)
        return div;

    return FindGreatestCommonDivisor(m, n, --div);
}

var nod = FindGreatestCommonDivisor(35, 42, 42);

Console.WriteLine(nod);