// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} | ");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine("|");
    }
}

double[] AverageColumns(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++) sum += matrix[i, j];

        // double average = sum / matrix.GetLength(0);
        array[j] = Math.Round(sum / matrix.GetLength(0), 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}; ");
        else Console.Write($"{array[i]}.");
    }
}

int[,] matr = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(matr);
double[] arr = AverageColumns(matr);
PrintArray(arr);


// string PrintMatrix(double[,] matrix)
// {
//     string str = string.Empty;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         str += "[";
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j == matrix.GetLength(1) - 1) str += $" {matrix[i, j],3} ";
//             else str += $" {matrix[i, j],3}, ";
//         }
//         str += "]\n";
//     }
//     return str;
// }

// string PrintArray(double[] array)
// {
//     string str = "[";
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (str == "[") str += array[i];
//         else str = $", {array[i]}";
//     }
//     str += "]";
//     return str;
// }

// double[,] matr = CreateMatrixRndInt(3, 4, 0, 10);
// Console.WriteLine(PrintMatrix(matr));

// double[] arr = AverageColumns(matr);
// Console.WriteLine(PrintArray(arr));