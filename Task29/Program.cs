// Задача 29: Напишите программу, которая 
// задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] GenerateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    string numbers = string.Empty;
    for (int i = 0; i < arr.Length; i++)
    {
        numbers += Convert.ToString(arr[i]);

        if (i <= arr.Length - 2) numbers += ", ";
    }
    Console.Write($"[{numbers}]");
}

Console.Write("Введите диапазон элементов массива: \nОт: ");
int Min = Convert.ToInt32(Console.ReadLine());
Console.Write("До: ");
int Max = Convert.ToInt32(Console.ReadLine());

int[] array = GenerateArray(8, Min, Max);
PrintArray(array);