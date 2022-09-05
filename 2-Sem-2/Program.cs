// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int[] NumberToArray(int arg)
{
    string str_num = arg.ToString();
    int[] num_array = new int[str_num.Length];
    int i = 0;
    while ( i < str_num.Length )
    {
        num_array[i] = int.Parse(str_num(i));
        i++
    }
    return num_array;
}

int number = new Random().Next(100, 999);

Console.WriteLine(num_array);
