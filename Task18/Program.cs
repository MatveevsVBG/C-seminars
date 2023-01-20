// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

string Quarter(string digit)
{
    // if (digit == "1") return "x > 0  y > 0";
    // if (digit == "2") return "x < 0  y > 0";
    // if (digit == "3") return "x < 0  y < 0";
    // if (digit == "4") return "x > 0  y < 0";
    // return "Введены некорректные данные!";

    switch (digit)
    {
        case "1": return "Допустимые координаты: x > 0  y > 0";
        case "2": return "Допустимые координаты: x < 0  y > 0";
        case "3": return "Допустимые координаты: x < 0  y < 0";
        case "4": return "Допустимые координаты: x > 0  y < 0";
        default: return "Введены некорректные данные!";
    }
}
Console.WriteLine("Введите номер четверти:");
string number = Console.ReadLine();

string result = Quarter(number);
Console.WriteLine(result);