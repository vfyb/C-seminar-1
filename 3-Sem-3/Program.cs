// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

string GetAreaRange(int number)
    {
        if (number == 1) return "x > 0, y > 0";
        if (number == 2) return "x < 0, y > 0";
        if (number == 3) return "x < 0, y < 0";
        if (number == 4) return "x > 0, y < 0";
        return "There is no area";
    }

Console.WriteLine("Enter number of area: ");
int number = Convert.ToInt32(Console.ReadLine());

string answer = GetAreaRange(number);
Console.WriteLine($"Diapozone {answer}");
