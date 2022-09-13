// Задача 24: 
// Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10

int SumNumber(int num)
{
    int result = 0;

    for ( int i = 1; i <= num; i++)
    {
        result = result + i;
    }

    return result;
}

Console.WriteLine("Enter number: ");

try
{
    int number = Convert.ToInt32(Console.ReadLine());

    int sign = 1;
    if (number < 0) sign = -1;

    int sum = SumNumber(Math.Abs(number)) * sign;

    Console.WriteLine($"Sum of numbers from {sign} to {number}:");
    Console.WriteLine($"{sum}");
}
catch (Exception ex)
{
    Console.WriteLine($"Not number was entered. Error; {ex.Message}");
}


