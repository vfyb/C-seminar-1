// Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа.

void DeleteSecondDigit()
    {
        int number = new Random().Next(100, 1000);
        int digit1 = number / 100;
        int digit3 = number % 10;

        int new_number = digit1 * 10 + digit3;

        Console.WriteLine($"Generated number {number}");
        Console.WriteLine($"Number without second digit {new_number}");
    }

DeleteSecondDigit();
