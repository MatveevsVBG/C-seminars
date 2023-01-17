// 9. Напишите программу, которая 
// 1. выводит случайное число 
// 2. из отрезка [10, 99] и 
// 3. показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    // if (firstDigit > secondDigit) return firstDigit;
    // return secondDigit;                              // return возвращает значение и к месту входа в метод
    // или:
    int max = firstDigit > secondDigit ? firstDigit : secondDigit;
    return max;
}

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}");

int maxNum = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа => {maxNum}");

int maxNum1 = MaxDigit(45);
Console.WriteLine($"Наибольшая цифра числа => {maxNum1}");

int maxNum2 = MaxDigit(72);
Console.WriteLine($"Наибольшая цифра числа => {maxNum2}");

// int max = a > b? a: b