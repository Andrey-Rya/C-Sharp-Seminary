// Программа принимает на вход координаты точки (X и Y), 
// которые не равны нулю и выдает номер четверти плоскости,
// в которой эта точка находится
int[]point = new int [2]; // выделяем массив на 2 значения (X,Y)
Console.WriteLine("Введите координату Х:  ");
point[0] = Convert.ToInt32(Console.ReadLine()); // под номером 0 записали Х
Console.WriteLine("Введите координату Y:  ");
point[1] = Convert.ToInt32(Console.ReadLine()); // под номером 1 записали Y
if(point[0] > 0 && point[1] > 0)
{
    Console.WriteLine("Первая четверть"); // && - это лог символ И
}
else if (point[0] < 0 && point[1] > 0)
{
    Console.WriteLine("Вторая четверть"); 
}
else if (point[0] < 0 && point[1] < 0)
{
    Console.WriteLine("Третья четверть");
}
else if (point[0] > 0 && point[1] < 0)
{
    Console.WriteLine("Четвертая четверть");
}
else
{
    Console.WriteLine("Точка находится на оси");
}

Console.WriteLine();
Console.WriteLine($"Потому что Х = {point[0]}");
Console.WriteLine($"Потому что Y = {point[1]}");
