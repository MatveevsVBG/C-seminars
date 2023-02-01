// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// x = (b2-b1) / (k1-k2)
// y = k1 * (b2-b1) / (k1-k2) + b1 = (k1*b2 - k2*b1) / (k1 - k2)

double ValueX(int B1, int K1, int B2, int K2)
{
    double x = Convert.ToDouble(B2 - B1) / (K1 - K2);
    x = Math.Round(x, 2);
    return x;
}

double ValueY(int B1, int K1, int B2, int K2)
{
    double y = Convert.ToDouble(K1 * B2 - K2 * B1) / (K1 - K2);
    y = Math.Round(y, 2);
    return y;
}

Console.WriteLine("Введите значения:");
Console.Write("b1 = ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("k1 = ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b2 = ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("k2 = ");
int k2 = Convert.ToInt32(Console.ReadLine());

double X = ValueX(b1, k1, b2, k2);
double Y = ValueY(b1, k1, b2, k2);
Console.Write($"Координаты точки пересечения -> ({X}; {Y})");