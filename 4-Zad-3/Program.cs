// Задача 29: 
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// Элементы массива вводятся пользователем.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

// Method for getting array from user
int[] GetArrayFromUser()
{
    int[] array = new int[8];

    for ( int i = 0; i < array.Length; i++ )
    {
        Console.WriteLine($"Enter {i + 1} element of array: ");
        array[i] = GetAnyNumber();
    }

    return array;
}

// Method for getting Number from entered string
int GetAnyNumber()
{
    while (true)
    {
        try
        {
            int result = Convert.ToInt32(Console.ReadLine());
            return result;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"No number was entered. Error: {ex.Message}");
            Console.WriteLine("Please, try again:");
        }
    }   
}

// Method for printing array
void PrintArrayToConsole(int[] array)
{
    Console.Write("Your array: [");

    for ( int i = 0; i < array.Length; i++ ) 
    {
        if ( i != array.Length - 1 ) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}]");
    }
}

int[] user_array = GetArrayFromUser();
PrintArrayToConsole(user_array);
