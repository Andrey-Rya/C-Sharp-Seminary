// программа меняет местами первую и последнюю строку двумерного массива.

// === вариант решения через метод === //
const int ROWS = 3;
const int COLUMNS = 3;
// === заполняем массив случ числами через метод === //
int[,] FillMatrixRandom(int rows, int columns, int leftRange = 0, int rightRange = 10)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) // идёи по всей строке
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // идём по столбцу
        {
            matrix[i, j] = rand.Next(leftRange, rightRange);
        }
    }
    return matrix;
}

// === вывод на печать === //
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) // идёи по всей строке
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // идём по столбцу
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] matrix = FillMatrixRandom(ROWS, COLUMNS);
PrintMatrix(matrix);

// === меняем первую и последнюю строку в массиве === //
Console.WriteLine();
for (int i = 0; i < matrix.GetLength(1); i++) // идем по столбцам
{
    int temp = matrix[0, i];
    matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
    matrix[matrix.GetLength(0) - 1, i] = temp;
}
PrintMatrix(matrix);



// === это мой вариант решения === //
// Console.Clear();
// double[,] table = new double[3,4];
// Console.WriteLine("Заданный двумерный массив: ");
// for (int i = 0; i < 3; i++)
// {
//     for (int j = 0; j < 4; j++)
//     {
//         table[i,j] = new Random().Next(1,9);
//         Console.Write($"{table[i,j]} ");
//     }
//     Console.WriteLine();
// }
// // === меняем первую и последнюю строку массива === //
// Console.WriteLine("Меняем первую строку на последнюю: ");
// for (int i = 2; i >= 0; i--)
// {
//     for (int j = 0; j < 4; j++)
//     {
//         Console.Write($"{table[i,j]} ");
//     }
//     Console.WriteLine();
// }


