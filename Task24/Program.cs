// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
int sumNum = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sumNum}");
}
else Console.WriteLine("Введено некорректное число!");

int SumNumbers(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}