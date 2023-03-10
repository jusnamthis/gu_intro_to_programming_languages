// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// k1 * x + b1 = k2 * x + b2
// k1*x - k2*x = b2 - b1

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int[] GetValuesForStraightLineEquation()
{
    Console.Write("Enter the k value: ");
    var k = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter the b value: ");
    var b = Convert.ToInt32(Console.ReadLine());

    return new int[] { k, b };
}

double CalculateIntersectionXPoint(int[] line1, int[] line2)
{
    int leftPart = line1[0] - line2[0]; // X part
    int rightPart = line2[1] - line1[1]; // Values part
    double intersectionPoint = (double)rightPart / leftPart;
    return intersectionPoint;
}

double CalculateYPointForLineEquation(int[] line, double xPoint)
{
    var yPoint = line[0] * xPoint + line[1];
    return yPoint;
}

void PrintStraightLineEquation(int[] line)
{
    Console.WriteLine($"y = {line[0]}*x + {line[1]}");
}

void GetStraightLinesEquationsAndCalculateIntersectionPoint()
{
    var line1 = GetValuesForStraightLineEquation();
    PrintStraightLineEquation(line1);

    var line2 = GetValuesForStraightLineEquation();
    PrintStraightLineEquation(line2);

    var intersectionXPoint = CalculateIntersectionXPoint(line1, line2);

    var line1YPoint = CalculateYPointForLineEquation(line1, intersectionXPoint);
    var line2YPoint = CalculateYPointForLineEquation(line2, intersectionXPoint);

    if (line1YPoint == line2YPoint)
    {
        Console.WriteLine($"Two lines intersect in ({intersectionXPoint}, {line2YPoint}) point");
    }
    else
    {
        Console.WriteLine("These lines don't intersect...");
    }
}

GetStraightLinesEquationsAndCalculateIntersectionPoint();