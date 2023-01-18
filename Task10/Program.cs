// Задача 10: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.

int SecondDig(int num)
{
    return num / 10 % 10;
}

Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = (int)Math.Abs(number);

if (number / 100 >= 1 && number / 100 < 10)
{
    int secondNum = SecondDig(number);
    Console.Write($" {secondNum}");
}
else Console.Write("Введено не трёхзначное число!");
