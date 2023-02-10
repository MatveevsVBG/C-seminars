//  Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//  Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] Create3DMatrixInt(int rows, int columns, int depth, int min, int max)
{
    int[,,] matrix = new int[rows, columns, depth];
    int[] numbers = new int[matrix.Length];
    int count = 0;
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                int tmpNum = rnd.Next(min, max + 1);
                while (numbers.Contains(tmpNum))
                {
                    tmpNum = rnd.Next(min, max + 1);
                }
                matrix[i, j, k] = tmpNum;
                numbers[count++] = tmpNum;
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k],3}({i},{j},{k})");
            }
        }
    }
}

int[,,] matr = Create3DMatrixInt(2, 2, 2, 10, 99);
PrintMatrix(matr);