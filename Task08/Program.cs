/* Задача 8: Напишите программу, которая на вход принимает
 число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.Write("Введите натуральное число: ");

int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    int count = 1;

    while (count <= number)
    {
        if (count % 2 == 0)
        {
            Console.Write($"{count}");
            if (count <= number - 2)
            {
                Console.Write(", ");
            }
        }
        count++;
    }
}
else
{
    Console.WriteLine("Введено не натуральное число! \nПопробуйте ещё раз!");
}