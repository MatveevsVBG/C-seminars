// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * (max - min) + min, 2);   //Для вещественных
    }
    return array;
}

void PrintArrayDouble(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("] -> ");
}

double FindMaxElem(double[] array)
{
    double maxElem = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxElem) maxElem = array[i];
    }
    return maxElem;
}

double FindMinElem(double[] array)
{
    double minElem = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minElem) minElem = array[i];
    }
    return minElem;
}

double[] arr = CreateArrayRndDouble(5, 0, 100);
PrintArrayDouble(arr);
double Max = FindMaxElem(arr);
Console.Write($"{Max} - ");
double Min = FindMinElem(arr);
Console.Write($"{Min} = ");
double result = Math.Round(FindMaxElem(arr) - FindMinElem(arr), 2);
Console.WriteLine(result);