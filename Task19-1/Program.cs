// Напишите программу, которая 
// принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Poliandrom(int num)
{
    int reminder = 0;
    int reversNumber = 0;
    while (num > 0)
    {
        reminder = num % 10;
        reversNumber = reversNumber * 10 + reminder;
        num /= 10;
    }
    return reversNumber;
}
Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);

int result = Poliandrom(number);
if (number == result) Console.Write("Это число - полиандром");
else Console.WriteLine("Это число - не полиандром");