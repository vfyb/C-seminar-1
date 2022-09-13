// Create array with 8 elements, filled with 0 and 1 randomly

int[] RandomArray()
{
    int[] array = new int[8];

    for ( int i = 1; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

void PrintArrayToConsole(int[] array)
{
    for ( int i = 1; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

int[] array = RandomArray();
PrintArrayToConsole(array);
Console.WriteLine("Hello, World!");
