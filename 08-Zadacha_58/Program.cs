// Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.
Console.Clear();
Console.WriteLine($"\nЗададим матрицу, которую можно перемножить. Количество столбцов первой матрицы должно равняться количеству строк второй");
Console.WriteLine($"\nВводим размеры матриц и диапазон случайных значений:");
int m = InputNum("Введите число строк 1-й матрицы: ");
int n = InputNum("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = InputNum("Введите число столбцов 2-й матрицы: ");
int range = InputNum("Введите диапазон случайных чисел: от 1 до ");

int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
Console.WriteLine($"\nВаша первая матрица:");
WriteArray(firstMartrix);

int[,] secomdMartrix = new int[n, p];
CreateArray(secomdMartrix);
Console.WriteLine($"\nВаша вторая матрица:");
WriteArray(secomdMartrix);

int[,] resultMatrix = new int[m, p];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
	for (int i = 0; i < resultMatrix.GetLength(0); i++)
	{
		for (int j = 0; j < resultMatrix.GetLength(1); j++)
		{
			int sum = 0;
			for (int k = 0; k < firstMartrix.GetLength(1); k++)
			{
				sum += firstMartrix[i, k] * secomdMartrix[k, j];
			}
			resultMatrix[i, j] = sum;
		}
	}
}

int InputNum(string input)
{
	Console.Write(input);
	int output = Convert.ToInt32(Console.ReadLine());
	return output;
}

void CreateArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			array[i, j] = new Random().Next(1, range + 1);
		}
	}
}

void WriteArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write(array[i, j] + " ");
		}
		Console.WriteLine();
	}
}
