// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.

void DevidedMultiple(int num1, int num2)
    {
        if (num1 % num2 == 0) Console.WriteLine($"Number {num1} is a multiple of {num2}");
        else
            {
                Console.WriteLine($"Number {num1} is not a multiple of {num2}");
                Console.WriteLine($"The remainder of the division: {num1 % num2}");
            }
    }

Console.WriteLine("Enter first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

DevidedMultiple(number1, number2);
