// Программа принимает на вход 3-значное число и 
//на выходе показывает последнюю цифру.

Console.Write("Введите трёхзначное число: ");
int numb = Convert.ToInt32(Console.ReadLine());
numb = (int)Math.Abs(numb);      //модуль числа
int numbCheck = numb;
int count = 0;
while (numbCheck != 0)           // проверкка разрядности
{
    numbCheck = numbCheck / 10;
    count++;
}
if (count == 3) Console.WriteLine($"Последняя цифра: {numb % 10}");
else Console.Write("Введено не трёхзначное число!");