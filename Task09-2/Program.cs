// 9. Напишите программу, которая 
// 1. выводит случайное число 
// 2. из отрезка [10, 99] и 
// 3. показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}");
// int firstDigit = number / 10;
// int secondDigit = number % 10;
// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа => {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа => {secondDigit}");

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    if (firstDigit > secondDigit) return firstDigit;
    return secondDigit;        // return возвращает значение  и к месту
}
int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа => {maxDigit}");

int maxDigit1 = MaxDigit(45);
Console.WriteLine($"Наибольшая цифра числа => {maxDigit1}");

int maxDigit2 = MaxDigit(72);
Console.WriteLine($"Наибольшая цифра числа => {maxDigit2}");

// int max = a > b? a: b