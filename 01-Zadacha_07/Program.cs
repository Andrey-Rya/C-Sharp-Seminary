﻿// вводим трехзначное число и на выходе получаем его последнюю цифру
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
// если число находится в диапазоне от 99 до 1000 то делаем ниже-иначе на else
if (N > 99 & N < 1000)
{
    Console.WriteLine(N % 10); // % - показывает остаток от деления (в нашем случ от деления на 10)
}
else
{
    Console.WriteLine("Число не подходит");
}
