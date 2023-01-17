// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

// int remaines = Digit(int firstDigit, int secondDigit)

int Digit(int firstDigit, int secondDigit)
{

    if (firstDigit % secondDigit == 0) Console.WriteLine("Первое число кратно второму");
    else 
    {
        int result = firstDigit % secondDigit;
        
    }
    return result;
}
int digit = Digit(num1, num2);
Console.WriteLine($"Остаток от деления => {digit}");


