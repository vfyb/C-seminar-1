// User enter number
Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine());

// 2 degree of number
int result = Convert.ToInt32(Math.Pow(number, 2));

Console.WriteLine($"2 degree of number {number} = {result}");
