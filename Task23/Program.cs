// Напишите программу, которая 
// принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1) 
{
    Console.WriteLine("Введено не натуральное число");
    return;
}

 Cube(number);

void Cube(int number)
{
    int count = 1;
    while (count <= number)
    {
        Console.WriteLine($"{count, 5}  {Math.Pow(count, 3), 5}");
        count++;
    }
}
