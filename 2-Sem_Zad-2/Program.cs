// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

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

Console.WriteLine("Enter number: ");
int number = int.Parse(Console.ReadLine());
// int number = new Random().Next(100, 9999);

Console.WriteLine("Enter number of digit you want to delete: ");
int digit_del = int.Parse(Console.ReadLine());

int[] array = NumberToArray(number);
int final_number = DeleteAnyDigit(array, digit_del);

Console.WriteLine($"Your number is {number}.");
Console.WriteLine($"Your number without {digit_del} digit is {final_number}.");
