// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int[] CubeTable(int num)
{
    int[] result = new int[num];

    for ( int i = 0; i < num; i++ )
        {
            result[i] = Convert.ToInt32(Math.Pow((i + 1), 3));
        }
    return result;
}

void PrintCubeTable(int[] cube_table)
{
    int length = cube_table.Length;
    Console.Write("Cube table: ");

    for ( int i = 0; i < length; i++ )
        {
            if ( i != (length - 1) ) Console.Write($"{cube_table[i]}, ");
            else Console.WriteLine($"{cube_table[i]}.");
        }
}

Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] cube_table = CubeTable(number);

PrintCubeTable(cube_table);
