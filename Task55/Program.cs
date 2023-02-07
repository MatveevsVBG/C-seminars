// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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

// int[,] ReplaceRowsColumns (int[,] matrix)    // 1 вариант: создание нового массива - не оптимально: новый массив + проход по всем элементам.
// {
//     int[,] tmpArray = new int[matrix.GetLength(0), matrix.GetLength(1)];    
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {        
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {            
//             tmpArray[j, i] = matrix[i, j];            
//         }        
//     }
//     return tmpArray;
// }

// int[,] matr = CreateMatrixRndInt(4, 4, 1, 10);
// PrintMatrix(matr);
// int[,] replase = ReplaceRowsColumns(matr);
// Console.WriteLine();
// PrintMatrix(replase);

void ReplaceRowsColumns(int[,] matrix)     // 2 вариант: перезаписываем исходный массив, исключая главную диагональ.
{
    for (int i = 0; i < matrix.GetLength(0) - 1; i++)    // исключаем перезапись последнего элемента диагонали - [3,3]
    {
        for (int j = i + 1; j < matrix.GetLength(1); j++)  // перезапись начинается с элемента [0,1], исключаем элементы диагонали начиная с [0,0]
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}

int[,] matr = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(matr);
if (matr.GetLength(0) != matr.GetLength(1)) Console.WriteLine("Замена не возможна, массив не квадратный!");
else
{
    ReplaceRowsColumns(matr);
    Console.WriteLine();
    PrintMatrix(matr);
}