// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int[] Fibonacci(int size)
{
    int[] array = new int[size];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

void PrintArray(int[] array, int number)
{
    Console.Write($"Если N = {number} -> [");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
    Console.WriteLine($"]");
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] arr = Fibonacci(number);
PrintArray(arr, number);


// Вариант string:

// string PrintArray(int[] arr)
// {
//     string array = ($"{arr[0]}");
//     for (int i = 1; i < arr.Length; i++)
//     {
//         array = array + ($", {arr[i]}");
//     }
//     return array;
// }
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number > 0)
// {
//     int[] fib = Fibonacci(number);
//     Console.WriteLine($"Если N = {number} -> {PrintArray(fib)}");
// }
// else Console.WriteLine("Некорректный ввод");