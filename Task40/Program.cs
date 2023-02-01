// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите три числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
bool IsItTriangle(int A, int B, int C)
{
    if (A + B > C && A + C > B && B + C > A) return true;
    else return false;
}
Console.WriteLine(IsItTriangle(a, b, c)? "да" : "нет");