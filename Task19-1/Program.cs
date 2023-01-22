// Напишите программу, которая 
// принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Revers(int num)
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
string? number = Console.ReadLine();
bool checkNum = int.TryParse(number, out int trueNumber);
if (checkNum == true)
{
    trueNumber = Math.Abs(trueNumber);
    int result = Revers(trueNumber);
    if (trueNumber == result) Console.Write("Это число - полиандром.");
    else Console.WriteLine("Это число - не полиандром.");
}
else Console.WriteLine("Неверный ввод!");