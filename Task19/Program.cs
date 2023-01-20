// Напишите программу, которая 
// принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);

if (number / 10000 < 1 || number / 10000 > 10)
{
    Console.Write("Введено не пятизначное число!");
    return;
}

Poliandrom(number);

void Poliandrom(int num)
{
    if (num % 10 == num / 10000  && num / 10 % 10 == num / 1000 % 10) 
         Console.Write("Да");
    else Console.WriteLine("Нет");
}



