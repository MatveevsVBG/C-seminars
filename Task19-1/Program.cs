// Напишите программу, которая 
// принимает на вход любое число и 
// проверяет, является ли оно палиндромом.

long Revers(long num)
{
    long reminder = 0;
    long reversNumber = 0;
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
bool checkNum = long.TryParse(number, out long trueNumber);
if (checkNum == true)
{
    trueNumber = Math.Abs(trueNumber);
    long result = Revers(trueNumber);
    if (trueNumber == result) Console.Write("Это число - палиндром.");
    else Console.WriteLine("Это число - не палиндром.");
}
else Console.WriteLine("Неверный ввод!");