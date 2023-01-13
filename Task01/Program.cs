Console.Write("Введите число 1 ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2 ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 / number2 == number2)
{
  Console.WriteLine($"Число {number1} является квадратом числа {number2}");
}
else
{
  Console.WriteLine($"Число {number1} не является квадратом числа {number2}");
}