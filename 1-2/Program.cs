// Вводим 2 числа и проверяем, является ли первое квадратом второго
Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 == Convert.ToInt32(Math.Pow(number2, 2)))
    {
        Console.WriteLine($"Число {number1} является квадратом числа {number2}");
    }
else    
    {
        Console.WriteLine($"Число {number1} НЕ является квадратом числа {number2}");
    }