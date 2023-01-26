// Задача 27: Напишите программу, 
// которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int SumNumber(int num)
// {
//     int res = 0;
//     while (num != 0)
//     {
//         int temp = num % 10;
//         res = res + temp;
//         num = num / 10;
//     }
//     return res;
// }

int SumNumber(int num)
{
    int counter = num;
    int res = 0;
    for (int i = 0; i < counter; i++)
    {
        int temp = num % 10;
        res = res + temp;
        num = num / 10;
    }
    return res;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number *= -1;
if (number != 0)
{
    int sum = SumNumber(number);
    Console.WriteLine($"Сумма цифр в числе -> {sum}");
}
else Console.WriteLine("Некорректный ввод!");