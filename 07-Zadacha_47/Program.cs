// зададим двумерный массив размером m x n, заполненный 
// случайными вещественными числами


Console.Clear();
Console.WriteLine("Задайте двумерный массив m x n");
Console.WriteLine();
Console.Write("Введите количество строк m:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов  n:  ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[m, n]; // задаем двумерный массив

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = Convert.ToDouble(new Random().Next(-100, 100))/10; // заполняем строку
        Console.Write(matrix[i, j] + "  ");
    }
    Console.WriteLine();
}

