// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.

int[] SqrtTable(int num)
    {
        int[] sqrtArray = new int[num];

        for ( int i = 0; i < num; i++ )
            {
                sqrtArray[i] = Convert.ToInt32(Math.Pow((i + 1), 2));
            }
        return sqrtArray;
    }

Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] result = SqrtTable(number);
for ( int i = 0; i < number; i++ )
    {
        Console.WriteLine(result[i]);
    }




// string GetSquareTable(int number)
//     {
//         string str_table = "";

//         for ( int i = 1; i <= number; i++ )
//             {
//                 str_table = str_table + $"{Math.Pow(i, 2)}, " ;
//             }
//         return str_table;
//     }

// Console.WriteLine("Enter number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// string str_table = GetSquareTable(number);
// Console.WriteLine($"{str_table}");
