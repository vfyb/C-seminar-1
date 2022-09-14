// Задача 37: 
// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве. 
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
 
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

// Method create array with random elements from -10 to 10
int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    var random = new Random();

    for ( int i = 0; i < size; i++ ) 
    {
        array[i] = random.Next(-10, 11);
    }
    return array;
}

// Method for getting new array with multiplied element (first * last, first+1 * last-1, ...)
int[] GetNewMultipleArray(int[] array)
{
    int newSize = Convert.ToInt32((array.Length + 1) / 2);
    int[] newArray = new int[newSize];

    if ( array.Length % 2 == 0 ) 
    {
        for ( int i = 0; i < newSize; i++ ) 
        {
            newArray[i] = array[i] * array[array.Length - i - 1];
        }
    }
    else
    {
        for ( int i = 0; i < newSize - 1; i++ ) 
        {
            newArray[i] = array[i] * array[array.Length - i - 1];
        }
        newArray[newSize - 1] = array[newSize -1];
    }
    return newArray;
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

int sizeArray = GetAnyNumber("size of array");

int[] oldArray = CreateRandomArray(sizeArray);
int[] newArray = GetNewMultipleArray(oldArray);

PrintArrayToConsole(oldArray, "Old array");
PrintArrayToConsole(newArray, "New array");
