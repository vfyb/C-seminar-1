// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

double GetDistance(int x1, int y1, int x2, int y2)
    {
        double result = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        result = Math.Round(result , 2, MidpointRounding.ToNegativeInfinity);
        return result;
    }

Console.WriteLine("Enter x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double distance = GetDistance(x1, y1, x2, y2);
Console.WriteLine($"Distance = {distance}");
