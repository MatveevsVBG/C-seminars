// Задача 15: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.

bool Weekday(int weekDay)
{
    return weekDay == 6 || weekDay == 7;
}

int[] array = { 1, 2, 3, 4, 5, 6, 7 };
Console.WriteLine("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (array.Contains(day))
{
    bool weekEnd = Weekday(day);
    Console.WriteLine(weekEnd ? "Выходной день :)" : "День не является выходным :(");
}
else Console.WriteLine("Неправильно введён номер дня недели!");


