// Задача 13: Напишите программу, которая выводит
// третью слева цифру заданного числа или сообщает, что третьей
// цифры нет.

int Separate(int num)
{  
    return num % 10;
}

int number = new Random().Next(-10000, 10000);
Console.WriteLine($"Случайное число => {number}");
if (number < 0) number = number * (-1);
if (number >= 100)
    {
        while (number > 1000)
        {
            number = number / 10;
        }
    }
else Console.WriteLine("Третьей цифры нет.");

int thirdDig = Separate(number);
Console.WriteLine(thirdDig);