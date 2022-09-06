// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

void Multiple7and23(int arg)
    {
        if ( arg % 7 == 0 && arg % 23 == 0 ) Console.WriteLine($"Number {arg} is a multiple of 7 and 23.");
        else Console.WriteLine($"Number {arg} is not a multiple of 7 and 23.");
    }

Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

Multiple7and23(number);
