// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double GetDistanceThreePoints()

int[] GetPointCoordinates(string point_number)
{    
    string[] xyz = new string[3] {"X", "Y", "Z"};
    int[] array_point = new int[3];

    for ( int i = 0; i < 3; i++ )
    {
        Console.WriteLine($"Enter {xyz[i]} coordinate of the {point_number} point: ");
        array_point[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array_point;
}

double GetDistanceTwoPoints(int[] array_point_1, int[] array_point_2)
{
    double result = 0;
    double sum_of_square = 0;

    for ( int i = 0; i < 3; i++ )
    {
        sum_of_square = sum_of_square + Math.Pow(array_point_1[i] - array_point_2[i], 2);
    }
    
    result = Math.Round(Math.Sqrt(sum_of_square), 2, MidpointRounding.ToNegativeInfinity);
    return result;
}

int[] array_point_1 = GetPointCoordinates("first");
int[] array_point_2 = GetPointCoordinates("second");

double distance = GetDistanceTwoPoints(array_point_1, array_point_2);

Console.WriteLine($"Distance between two points {distance}.");

// for ( int i = 0; i < 3; i++ ) Console.WriteLine($"{array_point_1[i]}");
// for ( int i = 0; i < 3; i++ ) Console.WriteLine($"{array_point_2[i]}");