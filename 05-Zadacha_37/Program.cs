﻿// найти произведение чисел в одномерном массиве
// пара-это первый х последний, второй х предпоследний эл-т
// вывод в новом массиве
int[] FillArray(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

int[] array = FillArray(5, -5, 8);
int newLenght = array.Length / 2 + array.Length % 2;
int[] newArray = new int[newLenght];
for (int i = 0; i < array.Length / 2; i++)
{
    newArray[i] = array[i] * array[array.Length - 1 - i];
}

if (array.Length % 2 > 0)
{
    newArray[newArray.Length - 1] = array[array.Length / 2];
}
Console.WriteLine('[' + string.Join(", ", array) + ']');
Console.WriteLine('[' + string.Join(", ", newArray) + ']');
