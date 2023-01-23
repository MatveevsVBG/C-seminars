// Напишите программу, которая 
// принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);

if (number < 10000 || number > 99999)
{
    Console.Write("Введено не пятизначное число!");
    return;
}

bool result = Palindrom(number);

if (result) Console.Write("Палиндром.");
else Console.WriteLine("Не палиндром.");

bool Palindrom(int num)
{
    return num % 10 == num / 10000 && num / 10 % 10 == num / 1000 % 10;
}