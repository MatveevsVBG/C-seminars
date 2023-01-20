// Задача 13: Напишите программу, которая выводит
// третью слева цифру заданного числа или сообщает, что третьей
// цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Separate(int num)
{
    while (num > 999)
    {
        num = num / 10;
    }
    return num % 10;
}

Console.WriteLine("Введите любое целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = number * (-1);
if (number < 100) Console.WriteLine("Третьей цифры нет.");
else 
{
    int thirdDig =Separate(number);
    Console.WriteLine($"  {thirdDig}");
}
