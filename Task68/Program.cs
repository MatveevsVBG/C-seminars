// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число m: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int N = Convert.ToInt32(Console.ReadLine());

if (M < 0 || N < 0) 
    Console.WriteLine("Неверный ввод!");
else
{
    int functionA = Akkerman(M, N);
    Console.Write($"m = {M}, n = {N} -> A(m, n) = {functionA}");
}

int Akkerman(int n, int m)   // max m=3 n=10
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return Akkerman(n - 1, 1);
    if (n > 0 && m > 0) return Akkerman(n - 1, Akkerman(n, m - 1));
    return Akkerman(n, m);
}

// int Akkerman(int n, int m)     // max m=3 n=11
// {
//     while (n != 0)
//     {
//         if (m == 0) m = 1;
//         else m = Akkerman(n, m - 1);
//         n = n - 1;
//     }
//     return m + 1;
// }