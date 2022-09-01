// Вывести все целые числа от -N до N, которое ввел пользователь
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"

Console.Write("Enter number: ");
int number = Math.Abs(int.Parse(Console.ReadLine()));

int startNumber = number * -1;
while (startNumber <= number)
    {
        Console.WriteLine(startNumber);
        startNumber++;
    }