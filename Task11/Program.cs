// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
// 12 мин

int Digit(int num)
{
    int firstDigit = num / 100;
    int lastDigit = num % 10;
    int result = firstDigit * 10 + lastDigit;
    return result;
}

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трёхзначное число => {number}");
int digit = Digit(number);
Console.WriteLine($"Число => {digit}");