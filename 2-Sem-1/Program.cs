// Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

int MaxDigit(int arg)
{
    int second_digit = arg % 10;
    int first_digit = (arg / 10) % 10;

    int result = first_digit;

if ( second_digit > result )
    {
        result = second_digit;
    }
    return result;
}

int number = new Random().Next(10, 99);
Console.WriteLine(number);

int max = MaxDigit(number);
Console.WriteLine(max);
