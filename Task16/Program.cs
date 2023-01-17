bool Square(int number1, int number2)
{
    return number1 * number1 == number2 || number2 * number2 == number1;
}

Console.Write("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool result = Square(number1, number2);

// if (result) Console.WriteLine("да");
// else Console.WriteLine("нет");

// string res = result ? "да" : "нет";
// Console.WriteLine(res);

Console.WriteLine(result ? "да" : "нет");