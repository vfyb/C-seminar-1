// Напишите программу, которая удаляет заданную цифру заданного числа 
// или сообщает, что такой цифры нет..

// Преобразует число в массив и возвращает этот массив:
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

// Создает число в котором нет заданной цифры и возвращает новое число:
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

Console.WriteLine("Enter number of digit you want to delete: ");
int digit_del = int.Parse(Console.ReadLine());

int final_number = number;

// Узнаем отрицательное число или нет:
int number_sign = 1;
if ( number < 0 ) number_sign = -1;

int[] array = NumberToArray(Math.Abs(number));

// Узнаем есть ли в числе цифра с заданным номером:
if ( array.Length < digit_del) Console.WriteLine($"There is no {digit_del} digit.");
else final_number = number_sign * DeleteAnyDigit(array, digit_del);

Console.WriteLine($"Your number is {number}.");
Console.WriteLine($"Your number without {digit_del} digit is {final_number}.");
