﻿// программа принимает на вход одно число (N)
// а на выходе показывает все четные числа от 1 до N

Console.WriteLine("Введите число: ");// вводим число N
int N = Convert.ToInt32(Console.ReadLine()); // запоминаем число N
int count = 2; // присваиваем началу счетчика старт от 2

//-----------цикл с условием для вывода четных чисел от 1 до N--------
while (count >= 2 & count <= N)
{
   int A = count % 2;
     if (A == 0)
     {
        Console.WriteLine(count);
        A = A + 1;
     }
   count = count + 1; 
}
 