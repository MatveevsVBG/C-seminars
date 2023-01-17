// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

int Digit(int firstDigit, int secondDigit)
{
    return firstDigit % secondDigit;
}

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int digit = Digit(num1, num2);

if (digit == 0) Console.WriteLine("Первое число кратно второму.");
else
{
    Console.WriteLine("Первое число не кратно второму.");
    Console.WriteLine($"Остаток от деления => {digit}");
}







