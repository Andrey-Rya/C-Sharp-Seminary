// Программа по заданному номеру четверти, показывает
// диапазон возможных координат точек в этой четв (X и Y) 

int[] point = new int[1]; // выделяем массив на 1 значение (Z)
Console.WriteLine("Введите номер четверти:  ");
point[0] = Convert.ToInt32(Console.ReadLine()); // под номером 0 записали Z
// Console.WriteLine("Введите координату Y:  ");
// point[1] = Convert.ToInt32(Console.ReadLine()); // под номером 1 записали Y

if (point[0] == 1)
{
    Console.WriteLine($"Х > 0 и Y > 0"); // проверяем условие 1 четв
}
else if (point[0] == 2)
{
    Console.WriteLine($"Х < 0 и Y > 0");
}
else if (point[0] == 3)
{
    Console.WriteLine($"Х < 0 и Y < 0");
}
else if (point[0] == 4)
{
    Console.WriteLine($"Х > 0 и Y < 0");
}
else
{
    Console.WriteLine("Введены некорректные данные. Повторите ввод");
}

Console.WriteLine();
Console.WriteLine($"Номер четверти = {point[0]}");

