// Напишите программу, которая на вход принимает 3 числа и выдаёт, какое число большее.

Console.WriteLine("Enter first number: ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter second number: ");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter third number: ");
int number3 = int.Parse(Console.ReadLine());

if (number1 > number2)
    {
        if (number1 > number3)
        {
            Console.WriteLine($"Max = {number1}");
        }
        else
        {
            Console.WriteLine($"Max = {number3}");
        }
    }
else
    {
        if (number2 > number3)
        {
            Console.WriteLine($"Max = {number2}");
        }
        else
        {
            Console.WriteLine($"Max = {number3}");
        }
    }