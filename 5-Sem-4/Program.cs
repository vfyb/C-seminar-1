// Задача 35: 
// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int[] CreateRandomArray()
{
    int size = 123;
    int[] array = new int[size];
    var random = new Random();

    for ( int i = 0; i < size; i++ ) array[i] = random.Next(-300, 300);
    
    return array;
}

int GetQuantityInDiapazone(int[] array)
{
    int result = 0;

    for ( int i = 0; i < array.Length; i++ )
    {
        if ( array[i] >= 10 && array[i] <= 99 ) result++;
    }  

    return result;  
}

int[] newArray = CreateRandomArray();
for ( int i = 0; i < newArray.Length; i++ ) Console.Write($"{newArray[i]}, ");

int quantityInDiapazone = GetQuantityInDiapazone(newArray);
Console.WriteLine("");
Console.WriteLine($"Quantity of element in diapazone [10 ,99]: {quantityInDiapazone}");
