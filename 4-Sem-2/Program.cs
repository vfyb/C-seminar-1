// Задача 26: 
// Напишите программу, которая принимает на вход число и 
// выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// int NumberOfDigits(int number)
// {
//     int result = (Convert.ToString(number)).Length;
//     return result; 
// }

int NumberOfDigits(int number)
{
    int result = 0;
    if ( number == 0 ) result = 1;
    else
    {
        while ( number != 0 )
        {
            number = number / 10;
            result++;
        }
    }
    return result; 
}

Console.WriteLine("Enter number: ");

try
{
    int number = Convert.ToInt32(Console.ReadLine());
    int num_digits = NumberOfDigits(Math.Abs(number));

    Console.WriteLine($"Number of digits in {number} is {num_digits}");
}
catch (Exception ex)
{
    Console.WriteLine("Not number was entered");
}