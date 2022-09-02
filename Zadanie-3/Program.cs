// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным

Console.WriteLine("Enter number: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
    {
        Console.WriteLine($"Numder {number} is even");
    }
else 
    {
        Console.WriteLine($"Number {number} is odd");
    }
