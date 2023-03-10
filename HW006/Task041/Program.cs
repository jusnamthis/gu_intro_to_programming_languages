// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


int GetUserNumbersAmount()
{
    Console.Write("Enter the amount of digits: ");
    var amount = Convert.ToInt32(Console.ReadLine());
    return amount;
}

int GetDigitByUser()
{
    return Convert.ToInt32(Console.ReadLine());
}

bool CheckIfNumberIsPositive(int number)
{
    if (number > 0)
        return true;
    return false;
}

void GetUserNumbersAndCountPositive()
{
    var userNumsAmount = GetUserNumbersAmount();
    var counter = 0;
    var positiveNumbers = 0;

    while (counter < userNumsAmount)
    {
        if (CheckIfNumberIsPositive(GetDigitByUser()))
            positiveNumbers++;
        counter++;
    }

    Console.WriteLine($"User entered {positiveNumbers} positive numbers.");
}

GetUserNumbersAndCountPositive();
