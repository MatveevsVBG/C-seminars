
// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

// int remaines = Digit(int firstDigit, int secondDigit)

bool Digit(int digit)
{
    return digit % 7 == 0 && digit % 23 == 0;   
}
    
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool result = Digit(number);
if (result) Console.WriteLine("Кратно");   // if (result=true)
else Console.WriteLine("Не кратно");