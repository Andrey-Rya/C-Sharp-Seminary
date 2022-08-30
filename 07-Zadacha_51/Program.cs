// задать двумерный массив. Найти сумму элементов, находящихся на 
//главной диагонали (с индексами (0,0); (1;1) и т.д

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
Console.WriteLine($"Для облегчения подсчёта заполнил его цифрой от 1 до 9 ))");
int sum = 0;
for (int rows = 0; rows < m; rows++) // строки
{
    for (int columns = 0; columns < n; columns++) // столбцы
    {
        table[rows, columns] = new Random().Next(1, 9); 
        if (columns == rows)
        {
            sum = sum + (table[rows, columns]);
            Console.Write($"[{table[rows, columns]}] ");
            //Console.Write($" {table[rows, columns] * table[rows, columns]}");
        }
        else
        {
            Console.Write($"{table[rows, columns]} ");
        }
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine($"Сумма элементов главной диагонали = {sum}");