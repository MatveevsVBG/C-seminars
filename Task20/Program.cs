// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

double Distance(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
}

Console.WriteLine("Введите координаты первой точки");
Console.Write("X1: ");
int numX1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int numY1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.Write("X2: ");
int numX2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int numY2 = Convert.ToInt32(Console.ReadLine());

double distance = Distance(numX1, numY1, numX2, numY2);

distance = Math.Round(distance, 2, MidpointRounding.ToZero);

Console.WriteLine(distance);