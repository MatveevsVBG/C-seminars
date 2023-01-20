// Задача 10: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.

int SecondDig(int num)
{
    return num / 10 % 10;
}

Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);

int numCheck = number;
int count = 0;
while (numCheck != 0)
{
    numCheck = numCheck / 10;
    count++;
}
if (count == 3)
{
    int secondNum = SecondDig(number);
    Console.Write($" {secondNum}");
}
else Console.Write("Введено не трёхзначное число!");
