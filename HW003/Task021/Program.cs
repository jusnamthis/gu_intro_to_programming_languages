namespace Task021;
class Program
{
    // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

    static void Main(string[] args)
    {
        countThe3DDistance();
    }

    static int[] generateVector()
    {
        var rnd = new Random();
        var veсtor = new int[3];

        for (var i = 0; i < veсtor.Length; i++)
        {
            veсtor[i] = rnd.Next(-10, 10);
        }

        return veсtor;
    }

    static void showVector(int[] vector)
    {
        foreach (var point in vector)
        {
            Console.Write($"{point}, ");
        }
        Console.WriteLine();
    }

    static void countThe3DDistance()
    {
        var vector1 = generateVector();
        showVector(vector1);


        var vector2 = generateVector();
        showVector(vector2);

        countThe3DDistance(vector1, vector2);
    }

    static void countThe3DDistance(int[] vector1, int[] vector2)
    {
        double sumOfDistancesBetweenPoints = 0;
        for (int i = 0; i < vector1.Length; i++)
        {
            sumOfDistancesBetweenPoints += countTheDistanceBetweenTwoPoints(vector1[i], vector2[i]);
        }

        var distanceBetweenPoints = Math.Sqrt(sumOfDistancesBetweenPoints);

        Console.WriteLine($"The distance between two vectors in 3D space is -> {distanceBetweenPoints}");
    }

    static double countTheDistanceBetweenTwoPoints(int p1, int p2)
    {
        return Math.Pow(p2 - p1, 2);
    }
}
