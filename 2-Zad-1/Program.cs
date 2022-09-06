// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

void SecondDigit(int num)
    {
        if ( Math.Abs(num) < 100 ^ Math.Abs(num) > 999 ) 
            {
                Console.WriteLine("You entered NOT three-digit number.");
            }
        else 
            {
                int second_digit = Math.Abs(( num / 10 ) % 10);
                Console.WriteLine($"Second digit of number {num} is:");
                Console.WriteLine($"{second_digit}");
            }
        
    }
Console.WriteLine("Enter three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

SecondDigit(number);
