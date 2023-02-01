// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

string ConvertToBinary(int num)
{
    string res = string.Empty;
    while (num > 0)
    {
        res = num % 2 + res;
        num /= 2;
    }
    return res;
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

string result = ConvertToBinary(number);
Console.Write(result);



// int BinaryNumber(int num)
// {
//     int count = 1;
//     int res = 0;
//     while (num > 0)
//     {
//         res = res + num % 2 * count;
//         num /= 2;
//         count *= 10;
//     }
//     return res;
// }
// int binResult = BinaryNumber(number);
// Console.Write(binResult);