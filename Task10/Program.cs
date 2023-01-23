// Задача 10: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.

int SecondDig(int num)
{
    return num / 10 % 10;
}
Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = (int)Math.Abs(number);    // приведение к int не нужно!
if (number < 100 || number > 999)
{
    Console.Write("Введено не трёхзначное число!");
    return;
}
int secondNum = SecondDig(number);
Console.Write($" {secondNum}");