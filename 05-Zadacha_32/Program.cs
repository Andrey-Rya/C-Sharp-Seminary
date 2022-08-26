// Программа замены положит элементов массива на отрицательные
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 
int[] array = new int[4]; // задали массив из 4-х симв
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-9, 10);
}
Console.WriteLine('[' + string.Join(", ", array) + ']');
for (int i = 0; i < array.Length; i++)
{
    array[i] *= -1; // умножаем каждый символ на -1
}
Console.WriteLine('[' + string.Join(", ", array) + ']');

