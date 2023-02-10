// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите два числа: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());

int sum = PowerNumbers(numberA, numberB);
Console.WriteLine(sum);

int PowerNumbers(int num1, int num2)
{
    return num2 == 0 ? 1 : num1 * PowerNumbers(num1, num2 - 1);  // Степень уменьшается каждый раз на 1
}                                                                // число не уменьшается