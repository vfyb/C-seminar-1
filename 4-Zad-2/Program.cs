// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Method for getting Number from entered string
int GetAnyNumber()
{
    int result = 0;
    Console.WriteLine($"Enter number: ");

    while (true)
    {
        try
        {
            result = Convert.ToInt32(Console.ReadLine());
            return result;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"No number was entered. Error: {ex.Message}");
            Console.WriteLine("Please, try again:");
        }
    }   
}

// Method for getting sum of digits of number
int GetSumOfDigits(int num)
{
    int result = 0;
    num = Math.Abs(num);

    while ( num != 0 )
        {
            result = result + (num % 10);
            num = (int)(num / 10);
        }
        
    return result;    
}

int number = GetAnyNumber();

int sum_of_digits = GetSumOfDigits(number);

Console.WriteLine($"Sum of digits of number {number} is: {sum_of_digits}");
