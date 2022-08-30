// программа на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого 
// элемента нет.

Console.Clear();
Console.Write($"Найдите элемент массива по его индексу: [X, Y] ");
Console.WriteLine();
Console.Write("Индекс X = ");
int X = Convert.ToInt32(Console.ReadLine());
Console.Write("Индекс Y = ");
int Y = Convert.ToInt32(Console.ReadLine());
int[,] table = new int[7, 7]; // задаем двумерный массив
Console.WriteLine();

// === рандомное заполнение массива === //
Console.Write("Вы ищете число в этом массиве:  ");
Console.WriteLine();
for (int rows = 0; rows < 7; rows++) // строки
{
    for (int columns = 0; columns < 7; columns++) // столбцы
    {
        table[rows, columns] = new Random().Next(1, 9);
        Console.Write($"{table[rows, columns]} ");
    }
    Console.WriteLine();
}
// === поиск числа по индексу в массиве === //
Console.WriteLine();
if (X <= 6 && X >= 0 && Y>= 0 && Y <= 6)
{
    Console.WriteLine($"Ваше искомое число в массиве с индексом [{X}, {Y}]  = {table[X, Y]}");
}
else
{
    Console.WriteLine("Такого элемента в массиве нет!");
}
