// найти сумму чисел на нечетных индексах в случайном
// одномерном массиве

/*===Задаем массив из 7-ми символов===*/
Console.Clear();
int[] array = new int[7];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-9, 10);
}
Console.Write("Ваш случайный массив: ");
Console.WriteLine('[' + string.Join(", ", array) + ']');

/*===Находим сумму элементов на нечетных позициях===*/
int sum = 0;
for (int i = 1; i < array.Length; i+=2)
{
    sum = sum + array[i]; // умножаем каждый символ на -1
}
Console.WriteLine();
Console.WriteLine($"Сумма элементов на нечетных позициях = {sum}");
