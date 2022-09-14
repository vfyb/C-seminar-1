// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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

// Method create array with random elements from 100 to 999
int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    var random = new Random();

    for ( int i = 0; i < size; i++ ) 
    {
        array[i] = random.Next(100, 1000);
    }
    return array;
}

// Method for counting quantity of even numbers in array
int CountEvenNumbersInArray(int[] array)
{
    int count = 0;

    for ( int i = 0; i < array.Length; i++ )
    {
        if ( array[i] % 2 == 0 ) count++;
    }
    return count;
}

// Method for printing array
void PrintArrayToConsole(int[] array, string text)
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

int size = GetAnyNumber("size of array");

if ( sizeArray < 1 ) 
{
    Console.WriteLine($"Can't create array with size {sizeArray}.\n");
}
else
{
    int[] randomArray = CreateRandomArray(size);
    int countOfEvenNumbers = CountEvenNumbersInArray(randomArray);

    PrintArrayToConsole(randomArray, "Random array");
    Console.WriteLine($"{countOfEvenNumbers} even numbers in this array.");
}
