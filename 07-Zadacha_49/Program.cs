// задать двумерный массив. Замените элементы с чётными 
// индексами на их квадраты

Console.Clear();
Console.WriteLine("Задайте двумерный массив m x n");
Console.WriteLine();
Console.Write("Введите количество строк m:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов  n:  ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] table = new int[m, n]; // задаем двумерный массив
Console.WriteLine();

// === Вывод исходного массива из случайных цифр === //
Console.WriteLine($"Исходный массив из {m} строк и {n} столбцов");
Console.WriteLine($"Для облегчения подсчёта заполнил его цифрой 3 ))");
for (int rows = 0; rows < m; rows++) // строки
{
    for (int columns = 0; columns < n; columns++) // столбцы
    {
        table[rows, columns] = new Random().Next(3,3); // для ускорения проверки заполняем цифрой 3
        if (columns % 2 == 0 && rows % 2 == 0)
        {
            Console.Write($" {table[rows, columns] * table[rows, columns]}");
        }
        else
        {
            Console.Write($" {table[rows, columns]}");
        }       
    }
    Console.WriteLine();
}
