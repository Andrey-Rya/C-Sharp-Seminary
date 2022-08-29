// зададим двумерный массив размером m x n. Каждый элемент 
// массива находим по формуле А = m + n

Console.Clear();
Console.WriteLine("Задайте двумерный массив m x n");
Console.WriteLine();
Console.Write("Введите количество строк m:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов  n:  ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] table = new int[m, n]; // задаем двумерный массив

for (int rows = 0; rows < m; rows++) // счетчик строк
{
    for (int columns = 0; columns < n; columns++) // счетчик столбцов
    {
        Console.Write($"  {table[rows, columns]=rows+columns}  ");
    }
    Console.WriteLine();
}
