// зададим двумерный массив размером m x n, заполненный 
// случайными целыми числами


Console.Clear();
Console.WriteLine("Задайте двумерный массив m x n");
Console.Write("Введите m:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n:  ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n]; // задаем двумерный массив

for (int i = 0; i < m; i++)
{
	for (int j = 0; j < n; j++)
	{
		matrix[i, j] = new Random().Next(-100, 100); // заполняем строку
		Console.Write(matrix[i, j] + " ");
	}
	Console.WriteLine();
}
