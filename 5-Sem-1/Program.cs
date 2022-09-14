// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

int[] GetArray(int size, int startValue, int endValue)
{
    var array = new int[size];
    var random = new Random();

    for ( int i = 0; i < array.Length; i++ )
    {
        array[i] = random.Next(startValue, endValue + 1);
    }
    return array;
}

int GetPositiveSum(int[] array)
{
    var sum = 0;

    for ( int i = 0; i < array.Length; i++ )
    {
        if ( array[i] > 0) sum = sum + array[i];
    }
    return sum;
}

int GetNegativeSum(int[] array)
{
    var sum = 0;

    for ( int i = 0; i < array.Length; i++ )
    {
        if ( array[i] < 0) sum = sum + array[i];
    }
    return sum;
}

var array = GetArray(12, -9, 9);
var sum_positive = GetPositiveSum(array);
var sum_negative = GetNegativeSum(array);

for ( int i = 0; i < array.Length; i++ ) Console.Write($"{array[i]}, ");

Console.WriteLine(" ");
Console.WriteLine($"Positive: {sum_positive}\n" +
                  $"Negative: {sum_negative}");

