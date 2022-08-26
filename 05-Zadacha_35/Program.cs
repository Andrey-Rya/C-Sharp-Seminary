// На входе массив из 123-х случайных чисел. Найдите кол-во
// эл-тов массива из отрезка 10-99 и просуммируйте их

/*===задали массив из 123 симв===*/
Console.Clear();
int[] array = new int[123]; 
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(0, 200);
}
Console.WriteLine("Наш случайный массив из 123-х символов: ");
Console.WriteLine('[' + string.Join(", ", array) + ']');
int counter = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= 10 && array[i] <= 99)
    {
        counter++;
    }
}
System.Console.WriteLine();
System.Console.WriteLine($"В промежутке от 10 до 99 находится {counter} элем.");
