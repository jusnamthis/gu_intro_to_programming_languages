namespace Task015;
class Program
{
    static void Main(string[] args)
    {
        checkIfTheDayIsWeekend();
    }

    static void checkIfTheDayIsWeekend()
    {
        var dayNum = new Random().Next(1, 8);
        checkIfTheDayIsWeekend(dayNum);
    }

    static void checkIfTheDayIsWeekend(int dayNum)
    {
        Console.WriteLine($"Day to check is -> {dayNum}");
        switch (dayNum)
        {
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
                Console.WriteLine("This day is not weekend day!");
                break;
            case 6:
            case 7:
                Console.WriteLine("This day is weekend day!");
                break;
            default:
                Console.WriteLine("Wrong day of the week...");
                break;
        }

    }
}
