
// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[] ArrayProductFirstLast(int[] array)
{
    int size = array.Length / 2;
    if (array.Length % 2 == 1) size += 1;
    int[] arrayNew = new int[size];
    for (int i = 0; i < size; i++)
    {
        arrayNew[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 == 1) arrayNew[arrayNew.Length - 1] = array[array.Length / 2];
    return arrayNew;
}

int[] arr = CreateArrayRndInt(5, -5, 15);
PrintArray(arr);

int[] countElem = ArrayProductFirstLast(arr);
PrintArray(countElem);