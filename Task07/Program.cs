// Программа принимает на вход 3-значное число и 
//на выходе показывает последнюю цифру.

Console.Write("Введите трёхзначное число: ");
int triNum = Convert.ToInt32(Console.ReadLine());
triNum = (int)Math.Abs(triNum);  //модуль числа
int triCheck = triNum; 
int count = 0;
if (triCheck == 0) count = 1;  
while (triCheck != 0)           // проверкка разрядности
{
    triCheck = triCheck / 10;
    count++;
}
if (count == 3) Console.WriteLine($"Последняя цифра: {triNum % 10}");
else Console.Write("Введено не трёхзначное число!");