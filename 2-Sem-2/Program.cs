// Напишите программу, которая выводит введенную цифру заданного числа или сообщает, 
// что такой цифры нет..

int[] NumberToArray(int arg)
{
    string str_num = arg.ToString();
    int[] num_array = new int[str_num.Length];
    
    int i = 0;
    while ( i < str_num.Length )
    {
        num_array[i] = int.Parse(str_num[i].ToString());
        i++;
    }
    return num_array;
}

int DeleteAnyDigit(int[] num_array, int dig_del)
{
    string new_number = "";
    int result = 0;
    int index = 0;
    while ( index < num_array.Length )
    {
        if ( index != dig_del - 1 )
            {
                new_number = new_number + num_array[index].ToString();
                index++;
            }
        else
            {
                index++;
            }
    }
    return result = int.Parse(new_number);
}

Console.WriteLine("Enter your number: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine("Enter number of digit you want to see: ");
int digit_del = int.Parse(Console.ReadLine());

int final_number = number;

int number_sign = 1;
if ( number < 0 )
    {
        number_sign = -1;
    }

int[] array = NumberToArray(Math.Abs(number));

if ( array.Length < digit_del)
    {
        Console.WriteLine($"There is no {digit_del} digit.");
    }
else
    {
        final_number = number_sign * DeleteAnyDigit(array, digit_del);
    }

Console.WriteLine($"Your number is {number}.");
Console.WriteLine($"Your number without {digit_del} digit is {final_number}.");
