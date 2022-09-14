// Задача 33: 
// Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
//  4; массив [6, 7, 19, 345, 3] -> нет 
//  -3; массив [6, 7, 19, 345, -3] -> да

int[] CreateNewRandomArray()
{
    int size = 12;
    int[] array = new int[size];

    for ( int i = 0; i < size; i++ ) array[i] = new Random().Next(-100, 100);
    
    return array;
}

bool CheckElementInArray(int[] array, int number)
{
    bool result = false;
    
    for ( int i = 0; i < array.Length; i++ ) 
    {
        if ( array[i] == number ) 
        {
            result = true;
            break;
        }
    }
    
    return result;
    
}

int[] newArray = CreateNewRandomArray();
for ( int i = 0; i < newArray.Length; i++ ) Console.Write($"{newArray[i]}, ");

Console.WriteLine(" ");
Console.WriteLine("Enter number:");
int number = Convert.ToInt32(Console.ReadLine());

bool check_element = CheckElementInArray(newArray, number);

if ( check_element == true ) Console.WriteLine($"Number {number} is in array.");
else Console.WriteLine($"Number {number} is not in array.");
