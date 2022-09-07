// // Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int[] NumberToArray(int num)
    {
        num = Math.Abs(num);
        int length = (num.ToString()).Length;
        // Console.WriteLine($"{length}");
        
        int[] array_number = new int[length];

        for ( int i = 0; i < length; i++ )
            {
                array_number[i] = (int)( num / Math.Pow(10, length-1-i));
                num = (int)(num % Math.Pow(10, length-1-i));
                // Console.WriteLine($"{array_number[i]}");
            }
        return array_number;
    }

bool Palindrome(int[] array)
    {
        int length = array.Length;
        bool result = false;

        for ( int i = 0; i < (int)(length/2); i++ ) 
            {
                if ( array[i] == array[length-1-i] )
                        result = true;
                else
                    {
                        result = false;
                        break;
                    }
            }
        return result;
        
    }

Console.WriteLine("Enter any number: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array_number = NumberToArray(number);

bool palindrome = Palindrome(array_number);

if ( palindrome == true ) Console.WriteLine($"Number {number} is a palindrome:");
else Console.WriteLine($"Number {number} is NOT a palindrome:");
