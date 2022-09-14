// Задача 37: 
// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве. 
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
 
int[] CreateRandomArray()
{
    int size = 7;
    int[] array = new int[size];

    for ( int i = 0; i < size; i++ ) array[i] = new Random().Next(-10, 11);
    
    return array;
}

int[] GetNewMultipleArray(int[] array)
{
    int newSize = Convert.ToInt32((array.Length + 1) / 2);
    Console.WriteLine($"{newSize}");
    int[] newArray = new int[newSize];

    if ( newSize % 2 == 1 ) 
    {
        for ( int i = 0; i < newSize; i++ ) newArray[i] = array[i] * array[array.Length - i - 1];
    }
    else
    {
        for ( int i = 0; i < newSize - 1; i++ ) newArray[i] = array[i] * array[array.Length - i - 1];
        newArray[newSize - 1] = array[newSize -1];
    }

    return newArray;
}

int[] oldArray = CreateRandomArray();
int[] newArray = GetNewMultipleArray(oldArray);

Console.WriteLine("Old array:");
for ( int i = 0; i < oldArray.Length; i++ ) Console.Write($"{oldArray[i]}, ");
Console.WriteLine("");
Console.WriteLine("Old array:");
for ( int i = 0; i < newArray.Length; i++ ) Console.Write($"{newArray[i]}, ");
