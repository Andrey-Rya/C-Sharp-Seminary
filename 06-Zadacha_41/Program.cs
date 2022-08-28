// пользователь вводит с клавиатуры М чисел. Считаем сколько
// чисел больше нуля введено 

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

/* находим сумму чисел больше нуля */
int summ = 0;
for (int z = 0; z < array.Length; z++)
{
    if (array[z] > 0) 
    {
        summ = summ +1;
    }
    
}
Console.WriteLine($"В данном массиве больше нуля {summ} знач.");
