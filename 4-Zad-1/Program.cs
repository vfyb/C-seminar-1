// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. Решить задачу 
// с использованием методов.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// double GetNumberInPower(int num, int pow)
// {
//     double result = 0;
//     result = Math.Pow(num, pow);

//     return result;
// }

// Method for getting Number in a Power with cycle (with Power < 0)
double GetNumberInPower(int num, int pow)
{
    double result = num;
    
    if ( pow == 0 ) result = 1;
    else 
    {
        for ( int i = 1; i < Math.Abs(pow); i++ ) result = result * num;
    }
    
    if ( pow < 0) result = 1 / result;
    
    return result;
}

// Method for getting Number from entered string
int GetAnyNumber(string arg)
{
    int result = 0;
    Console.WriteLine($"Enter {arg}: ");

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

int number = GetAnyNumber("number");
int power = GetAnyNumber("power");

double number_in_power = GetNumberInPower(number, power);

Console.WriteLine($"Number {number} in a power {power} is: {number_in_power}");
