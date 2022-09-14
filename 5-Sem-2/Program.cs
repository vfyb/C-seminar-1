// Задача 32: 
// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] array = new int[4] {-4, -8, 8, 2};

int[] ChangePositiveNegative(int[] array)
{
    int[] newArray = new int[4];

    for ( int i = 0; i < 4; i++ )
    {
        newArray[i] = array[i] * -1;
    }

    return newArray;
}

int[] newArray = ChangePositiveNegative(array);

for ( int i = 0; i < 4; i++ ) 
{
    Console.Write($"{array[i]}, ");
}

Console.WriteLine("");

for ( int i = 0; i < 4; i++ ) 
{
    Console.Write($"{newArray[i]}, ");
}
    
