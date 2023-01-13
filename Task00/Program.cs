// Составить программу, которая:
// 1. на вход принимает число
// 2. и выдает его квадрата
// 3. вывод результата

//  4 -> 16
// -3 -> 9
// -7 -> 49


//string numstr = Console.ReadLine();
Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
//Console.WriteLine("Квадрат числа " + number + " = " + square);  или
Console.WriteLine($"Квадрат числа {number} = {square}");