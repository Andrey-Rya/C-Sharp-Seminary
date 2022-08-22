// задаем ручной массив чисел и выводим произведение каждого из 
// числа от 1 до N

/* ввод количества элементов массива*/
Console.Write("Введите количество элементов массива: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[] array = new int[i];
for (int count = 0; count < i; count++)
{
    Console.Write($"Введите {count + 1}-й элемент массива: ");
    array[count] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(); // разделитель

/* находим произведение всех чисел массива*/
Console.WriteLine($"После произведения каждого числа массива от 1 до N получим:");
int sum = 0;
for (int y = 0; y <= i-1; y++)
    {
	sum = cycle(array[y]);
    Console.WriteLine($"{y+1}-й элемент массива = {sum}"); 
    } 
    return sum;

// используем функцию
int cycle(int a)
{
    int sum = 1;
    for (int i = 1; i <= a; i++)
    {
	sum = sum * i;
    } 
    return sum;
}
