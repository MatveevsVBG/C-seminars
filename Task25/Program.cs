// Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int PowerNamber(int num, uint power)
{
    int result = 1;
    for (int i = 1; i <= power; i++)
    {
        result *= num;
    }
    return result;
}


Console.WriteLine("Введите два числа: А и В:");
int number = Convert.ToInt32(Console.ReadLine());
string? exp = Console.ReadLine();
bool checkNum = uint.TryParse(exp, out uint trueExp);
if (checkNum == true)
{
    int res = PowerNamber(number, trueExp);
    Console.WriteLine($"{number} в степени {exp} = {res}");
}
else Console.WriteLine("Некорректный ввод");


// Console.WriteLine("Введите два числа: А и В:");
// int number = Convert.ToInt32(Console.ReadLine());
// int exp = Convert.ToInt32(Console.ReadLine());
// if (exp >= 0)
// {
//     int res = PowerNamber(number, exp);
//     Console.WriteLine($"{number} в степени {exp} = {res}");
// }
// else Console.WriteLine("Некорректный ввод");