// Задача 66: Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите два натуральных числа: ");
int numberM = Convert.ToInt32(Console.ReadLine());
int numberN = Convert.ToInt32(Console.ReadLine());
if (numberM <= 0 || numberN <= 0) 
    Console.WriteLine("Неверный ввод!");
else
{
    int sum = NaturalSumNumbers(numberM, numberN);
    Console.WriteLine($"M = {numberM}; N = {numberN} -> {sum}");
}

int NaturalSumNumbers(int num1, int num2)
{
    if (num2 == num1) return num1;
    return num1 < num2 ? num1 + NaturalSumNumbers(num1 + 1, num2)
                       : num1 + NaturalSumNumbers(num1 - 1, num2);
}