// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = SumDigits(number);
Console.WriteLine(sum);

int SumDigits(int num)
{
    return num == 0 ? 0 : num % 10 + SumDigits(num / 10);  // Берётся остаток от деления числа на 10 и 
}                                                          //  вызывается рекурсия "число делится на десять"