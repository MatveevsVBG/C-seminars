// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateRndMatrixInt(int rows, int columns, int min, int max)
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

int[] SumRowElements(int[,] matrix)
{
    int[] sumRow = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        sumRow[i] = sum;
    }
    return sumRow;
}

int MinSumRows(int[] sumRow)
{
    int index = 0;
    int minElem = sumRow[0];
    
    for (int i = 0; i < sumRow.Length; i++)
    {
        if (sumRow[i] < minElem)
        {
            minElem = sumRow[i];
            index = i;
        }
    }
    return index;
}

int[,] matr = CreateRndMatrixInt(4, 3, 1, 10);
PrintMatrix(matr);
int[] sumRow = SumRowElements(matr);
int rowNumber = MinSumRows(sumRow);
Console.WriteLine($"Наименьшая сумма элементов -> {rowNumber + 1} строка.");




// int SumRowElements(int[,] matrix)
// {
//     int indexMinSum = 0;
//     int sum = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         int sumRow = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             sumRow += matrix[i, j];
//         }
//         if (i == 0) sum = sumRow;
//         else
//         {
//             if (sumRow < sum)
//             {
//                 sum = sumRow;
//                 indexMinSum = i;
//             }
//         }
//     }
//     return indexMinSum;
// }

// int[,] matr = CreateRndMatrixInt(4, 3, 1, 10);
// PrintMatrix(matr);
// int rowNumber = SumRowElements(matr);
//  Console.WriteLine($"Наименьшая сумма элементов -> {rowNumber} строка.");