// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Sumnum(int number){
    int count = 0;
    while (number > 0)
    {
        number = number / 10;
        count ++;
    }
    return count;
}

Console.Write("Введите число:");
int numb = Convert.ToInt32(Console.ReadLine());
if (numb < 0) numb = numb * -1;

int sumNumber = Sumnum(numb);
Console.WriteLine($"Количество цифр в числе: {numb} -> {sumNumber}");