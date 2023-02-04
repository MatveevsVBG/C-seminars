// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет

int[,] CreateMatrixRndInt(int row, int colomn, int min, int max)
{
    int[,] matrix = new int[row, colomn];
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
        Console.Write($"|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} | ");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine("|");
    }
}

bool FindElement(int[,] matrix, int m, int n)
{
    return m <= matrix.GetLength(0) &&     // Индексы находятся в пределах количества строк
           n <= matrix.GetLength(1);       // и количества столбцов.
}

Console.WriteLine("Введите позицию элемента:");
int posM = Convert.ToInt32(Console.ReadLine());
int posN = Convert.ToInt32(Console.ReadLine());

if (posM < 0 || posN < 0) Console.WriteLine("Введены неверные данные!");  // Добавлена проверка на ввод отрицательных данных.
else
{
    int[,] matr = CreateMatrixRndInt(3, 4, 0, 10);
    PrintMatrix(matr);
    bool result = FindElement(matr, posM, posN);
    if (result) Console.Write($"{posM}, {posN} -> {matr[posM, posN]}");
    else Console.Write($"{posM}, {posN} -> такого элемента в массиве нет");
}


// string PrintMatrix(int[,] matrix)
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

// bool ShowPresenceNumber(int[,] matrixNumbers, int userRow, int userCollumn)
// {
//     return userRow < matrixNumbers.GetLength(0) && userCollumn < matrixNumbers.GetLength(1);
// }

// int[,] matrixNumbers = GenerateMatrix(3, 4, -10, 10);
// Console.WriteLine(PrintMatrix(matrixNumbers));

// Console.WriteLine("Введите позицию элемента начиная с 0.");
// Console.Write("Строка элемента: ");
// int userRow = Convert.ToInt32(Console.ReadLine());
// Console.Write("Столбец элемента: ");
// int userCollumn = Convert.ToInt32(Console.ReadLine());

// while (userRow < 0 || userCollumn < 0)
// {
//     Console.WriteLine("Неверный ввод. Введите позицию элемента начиная с 0.");
//     Console.Write("Строка элемента: ");
//     userRow = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Столбец элемента: ");
//     userCollumn = Convert.ToInt32(Console.ReadLine());
// }

// // if (userRow > matrixNumbers.GetLength(0) || userCollumn > matrixNumbers.GetLength(1)) Console.WriteLine("Такого элемента нет"); // вариант решения без метода
// // else Console.WriteLine($"Элемент массива - {matrixNumbers[userRow, userCollumn]}");

// bool presenceNumber = ShowPresenceNumber(matrixNumbers, userRow, userCollumn);
// Console.WriteLine(presenceNumber ? $"Элемент массива - {matrixNumbers[userRow, userCollumn]}" : "Такого элемента нет");