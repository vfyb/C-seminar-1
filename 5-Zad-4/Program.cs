// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Method for getting Number from entered string (size of array)
int GetAnyNumber(string text)
{
    int result = 0;
    Console.WriteLine($"Enter {text}: ");

    while (true)
    {
        try
        {
            result = Convert.ToInt32(Console.ReadLine());
            return result;
        }
        catch (Exception)
        {
            Console.WriteLine($"No number was entered.\n" +
                               "Please, try again:");
        }
    }   
}

// Method create array with random (double) elements from -300 to 300
double[] CreateRandomArray(int size)
{
    double[] array = new double[size];
    var random = new Random();

    for ( int i = 0; i < size; i++ ) 
    {
        array[i] = random.NextDouble() * random.Next(-300, 301);
    }
    return array;
}

// Method for printing array
void PrintArrayToConsole(double[] array, string text)
{
    Console.WriteLine($"{text}:");
    Console.Write("[ ");
    
    for ( int i = 0; i < array.Length; i++ ) 
    {
        if ( i != array.Length - 1 )
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.WriteLine($"{array[i]} ]");
        }
    }
}

// Method to find max and min in array and (max - min)
double FindDifferenceMaxMinInArray(double[] array)
{
    double max = array[0];
    double min = array[0];
    double result = 0;

    for ( int i = 1; i < array.Length; i++ )
    {
        if ( array[i] > max ) max = array[i];
        if ( array[i] < min ) min = array[i];
    }
    result = max - min;
    return result;
}

int sizeArray = GetAnyNumber("size of array");

if ( sizeArray < 1 ) 
{
    Console.WriteLine($"Can't create array with size {sizeArray}.\n");
}
else
{
    double[] arrayRandom = CreateRandomArray(sizeArray);
    double differenceMaxMin = FindDifferenceMaxMinInArray(arrayRandom);

    PrintArrayToConsole(arrayRandom, "Random array");
    Console.WriteLine($"Difference between maximum and minimum elements in array: {differenceMaxMin}");
}