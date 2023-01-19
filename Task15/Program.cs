// Задача 15: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.

bool WeekDay(int weekDay)
{
    return weekDay == 6 || weekDay == 7;
}

Console.WriteLine("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day > 0 && day < 8)
{
    bool weekEnd = WeekDay(day);
    Console.WriteLine(weekEnd ? "Выходной день :)" : "День не является выходным :(");   
}
else Console.WriteLine("Неправильно введён номер дня недели!");