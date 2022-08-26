// задать массив с положительными трехзначными числами
// подсчитать количество четных чисел в массиве

Console.Clear();
int[] array = new int[4]; // задали массив из 4-х симв
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(100, 1000);
}
Console.Write("Наш случайный массив: ");
Console.WriteLine('[' + string.Join(", ", array) + ']');
int counter = 0;
for (int i = 0; i < array.Length; i++)
 {
   if (array[i] % 2 == 0)
   {
        counter ++;
   }
 }
    Console.WriteLine($"Количество четных чисел в массиве = " + counter);

