// Зададим с клавиатуры массив (double) чисел и найдем
// разницу между макс и мин элементом массива

/* ввод элементов массива с клавиатуры */
Console.Clear();
Console.Write("Введите количество элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());
double[] array = new double[num];
for (int count = 0; count < num; count++)
{
    Console.Write($"Введите {count + 1}-й элемент массива: ");
    array[count] = Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine();

/* вывод введенного массива */
Console.Write($"Вы ввели этот массив: ");
Console.Write('[' + string.Join(", ", array) + ']');
Console.Write($" из {array.Length} чисел.");
Console.WriteLine();

/* находим макс и мин массива */
double min = array[0];
double max = array[0];

for (int z = 0; z < array.Length; z++)
{
    if (array[z] > max)
    {
        max = array[z];
    }
    if (array[z] < min)
    {
        min = array[z];
    }
}
Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
