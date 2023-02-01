// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"[{i}] = ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int CountNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}
Console.WriteLine("Введите количество проверяемых чисел: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите числа: ");

int[] arr = CreateArray(num);
int result = CountNumber(arr);
Console.WriteLine($"Количество чисел больше нуля: -> {result}");