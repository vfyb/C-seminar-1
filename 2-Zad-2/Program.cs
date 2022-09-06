// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

void ThirdDigitOfNumber(int num)
    {
        // Сразу ставим 2, потому что далее в if проверяем что >= 100:
        int rank = 2;

        if ( Math.Abs(num) < 100 ) Console.WriteLine($"There is no third digit in number {num}");
        else
            {
                // Узнаем разрядность числа (rank):
                while ( Math.Pow(10, rank) <= Math.Abs(num))
                    {
                        rank++;
                    }
                // Console.WriteLine($"Rank is {rank}");
                rank = rank - 3;
                int third_digit = (int)( Math.Abs(num) / Math.Pow(10, rank)) % 10 ;
                
                Console.WriteLine($"Third digit is {third_digit}");
            }
        
    }
Console.WriteLine("Enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());

ThirdDigitOfNumber(number);
