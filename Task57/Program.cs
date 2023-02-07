// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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

int[] CreateArray(int[,] matrix)
{
    int[] array = new int[matrix.Length];    // int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[count++] = matrix[i, j];
        }
    }
    return array;
}
void PrintArrayInt(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

void CountDictionary(int[] array)
{
    int tmp = array[0];
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (tmp == array[i]) count++;
        else
        {
            Console.WriteLine($"{tmp,2} - {count} шт.");
            tmp = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"{tmp,2} - {count} шт.");   // Вывод последнего элемента
}

int[,] matr = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(matr);
int[] arr = CreateArray(matr);
Array.Sort(arr);
Console.WriteLine();
PrintArrayInt(arr);
CountDictionary(arr);




// int[,] GenerateMatrix(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

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

// int[] MatrixToArray(int[,] matrix)
// {
//     int[] result = new int[matrix.Length];
//     int count = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             result[count++] = matrix[i, j];
//         }
//     }
//     return result;
// }

// string PrintArray(int[] arr)
// {
//     string str = String.Empty;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         str += $"{arr[i]} ";
//     }
//     return str;

// }

// void GetSameCountNubers(int[] arr)
// {
//     int tmp = arr[0];
//     int count = 1;
//     for (int i = 1; i < arr.Length; i++)
//     {
//         if (tmp == arr[i]) count++;
//         else
//         {
//             Console.WriteLine($"{tmp} - {count}");
//             tmp = arr[i];
//             count = 1;
//         }
//     }
//     Console.WriteLine($"{tmp} - {count}");
// }

// int[,] matrixNumbers = GenerateMatrix(3, 4, 0, 10);
// Console.WriteLine(PrintMatrix(matrixNumbers));

// int[] array = MatrixToArray(matrixNumbers);
// Array.Sort(array);
// Console.WriteLine(PrintArray(array));


// GetSameCountNubers(array);