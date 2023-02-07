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


int[] ConvertMatrixToArray(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k] = matrix[i, j];
            k++;
        }
    }
    return array;
}
int[,] FrequencyVocabulary(int[] array)
{
    int rowCounter = 1;
    for (int k = 1; k < array.Length; k++)
    {
        if (array[k] != array[k - 1]) rowCounter++;
    }
    int[,] vocabulary = new int[rowCounter, 2];
    int m = 0;
    int vocabularyCounter = 1;
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] != array[i + 1] && vocabulary[0, 0] != array[i])
        {
            vocabulary[m, 0] = array[i];
            vocabulary[m, 1] = vocabularyCounter;
            m++;
            vocabularyCounter = 1;
        }
        else
        { vocabularyCounter++; }
        vocabulary[m, 0] = array[array.Length - 1];
        vocabulary[m, 1] = vocabularyCounter;
    }
    return vocabulary;
}

int[,] matr = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(matr);
int[] arr = ConvertMatrixToArray (matr);
int [,] frequencyVocabulary = FrequencyVocabulary(arr);
Console.WriteLine();
PrintMatrix(frequencyVocabulary);
