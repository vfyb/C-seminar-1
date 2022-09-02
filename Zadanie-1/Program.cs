// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Enter first number: ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter second number: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 > number2)
    {
        Console.WriteLine($"Max = {number1}");
        Console.WriteLine($"Min = {number2}");
    }
else
    {
        Console.WriteLine($"Max = {number2}");
        Console.WriteLine($"Min = {number1}");
    }
