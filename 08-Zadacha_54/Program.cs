// создать двумерный массив и упорядочить по убыванию элементы каждой строки массива

Console.Clear();
Console.WriteLine($"\nВведите размер массива m x n из диапазона случайных чисел:");
int m = InputNum("Введите m: ");
int n = InputNum("Введите n: ");
int range = InputNum("Введите диапазон случайных чисел: от 1 до ");

Console.WriteLine($"\nВаш двумерный массив: ");
int[,] array = new int[m, n];
CreateArray(array);
PrintArray(array);

Console.WriteLine($"\nОтсортированный массив: ");
SortArray(array);
PrintArray(array);

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int a = 0; a < array.GetLength(1) - 1; a++)
            {
                if (array[i, a] < array[i, a + 1])
                {
                    int temp = array[i, a + 1];
                    array[i, a + 1] = array[i, a];
                    array[i, a] = temp;
                }
            }
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
            array[i, j] = new Random().Next(range);
        }
    }
}

void PrintArray(int[,] array)
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


