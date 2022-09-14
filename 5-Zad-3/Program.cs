// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Method create array with random elements from -50 to 50
int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    var random = new Random();

    for ( int i = 0; i < size; i++ ) 
    {
        array[i] = random.Next(-50, 51);
    }
    return array;
}

// Method for counting sum of elements on odd position
int GetSumOfNumbersWithOddIndex(int[] array)
{
    int result = 0;

    for ( int i = 0; i < array.Length; i++ )
    {
        if ( i % 2 == 1 )
        {
            result = result + array[i];
        }
    }

    return result;
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

int[] arrayRandom = CreateRandomArray(6);
int sumNumbersWithOddIndex = GetSumOfNumbersWithOddIndex(arrayRandom);

PrintArrayToConsole(arrayRandom, "Random array");
Console.WriteLine($"Sum of numbers with odd index: {sumNumbersWithOddIndex}");
