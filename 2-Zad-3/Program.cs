// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

void WeekEnd(int num)
    {
        if ( num < 1 ^ num > 7) Console.WriteLine("You entered incorrect number (correct is from 1 to 7)");
        else
            {
                if ( num == 6 ^ num == 7 ) Console.WriteLine($"Day {num} is weekend day.");
                else Console.WriteLine($"Day {num} is working day.");
            }
    }
Console.WriteLine("Enter number from 1 to 7: ");
int number = Convert.ToInt32(Console.ReadLine());

WeekEnd(number);
