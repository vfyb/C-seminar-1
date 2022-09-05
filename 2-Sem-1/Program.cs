// Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

int number = new Random().Next(10, 99);

Console.WriteLine(number);

int second_digit = number % 10;
int first_digit = (number / 10) % 10;

int max = first_digit;

if ( second_digit > max )
    {
        max = second_digit;
    }

Console.WriteLine(max);
