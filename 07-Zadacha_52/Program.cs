// Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце

double[,] table = new double[3, 4]; // задаем двумерный массив
Console.WriteLine("Наш двумерный массив: ");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        table[i,j] = new Random().Next(1,9);
        Console.Write($"{table[i,j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

// === находим среднее арифметическое эл-тов каждого столбца === //
double sum = 0;
int count = 0;
    for (int i = 0; i < 4; i++)
    {
        sum = 0;
        for (int j = 0; j < 3; j++)
        {
        double s = (table[j, i]);
        sum = sum + s;
        count = i;
            if (j == 2)
            {
                sum = sum / 3;    
            }
        }
        sum = Math.Round(sum, 2);
        Console.Write($"Средн арифм суммы {count}-х индексов столбца = {sum}");
        Console.WriteLine();
    }   

