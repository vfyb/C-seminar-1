// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Enter number: ");
int number = int.Parse(Console.ReadLine());

int even = 2;

if (number == 1)
    {
        Console.WriteLine("There is no even numbers.");
    }
else
    {
        Console.WriteLine($"Even numders between 1 and {number}: ");
        while ( even <= number )
            {
                Console.Write($"{even}, ");
                even = even + 2;
            }
    }
